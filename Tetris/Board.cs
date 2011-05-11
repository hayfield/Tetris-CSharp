using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    /// <summary>
    /// The game board
    /// </summary>
    class Board
    {
        /// <summary>
        /// Constructur to initialise the array to be showing PeachPuff color squares
        /// </summary>
        public Board(int noOfRows, int noOfColumns)
        {
            board = new int[noOfColumns, noOfRows + hiddenRows];
            for (int col = 0; col < noOfColumns; col++)
            {
                for (int row = 0; row < noOfRows + hiddenRows; row++)
                {
                    board[col, row] = boardColor;
                }
            }
            numberOfColumns = noOfColumns;
            numberOfRows = noOfRows;
            numberOfRowsTotal = noOfRows + hiddenRows;
            tick(); // stop a crash when holding a key down when starting a game
        }

        #region variables

        /// <summary>
        /// The default color of the board when there are no blocks there
        /// </summary>
        int boardColor = Color.PeachPuff.ToArgb();

        /// <summary>
        /// The board that is being played on.
        /// board[col, row]
        /// </summary>
        public int[,] board;

        /// <summary>
        /// The block that is currently being played
        /// </summary>
        public Block currentBlock;

        /// <summary>
        /// The number of rows that are hidden above the top of the grid
        /// </summary>
        public readonly int hiddenRows = 2;

        /// <summary>
        /// The number of visible columns on the board
        /// </summary>
        int numberOfColumns;

        /// <summary>
        /// The number of rows on the board
        /// </summary>
        int numberOfRows;

        /// <summary>
        /// The total number of rows on the board
        /// </summary>
        int numberOfRowsTotal;

        #endregion variables

        /// <summary>
        /// Ticks the board forward one move
        /// </summary>
        public void tick()
        {
            if (currentBlock == null || !canDropFurther())
            {
                spawnBlock();
            }

            lowerBlock();
            manageFullRows();
        }

        #region Board

        /// <summary>
        /// Creates a new block to play with
        /// </summary>
        private void spawnBlock()
        {
            // lock the previous block into position
            lockBlock();

            // spawn a new block
            currentBlock = new Block();
        }

        /// <summary>
        /// Locks the current block into position on the board
        /// </summary>
        private void lockBlock()
        {
            if (currentBlock != null)
            {
                // loop through each of the squares within the current block
                for (int col = 0; col < currentBlock.squares.GetLength(0); col++)
                {
                    for (int row = 0; row < currentBlock.squares.GetLength(1); row++)
                    {
                        // if there's something there
                        if (currentBlock.squares[row, col])
                        {
                            // lock it into position on the board
                            Coordinate coord = currentBlock.toBoardCoordinates(new Coordinate(col, row));
                            board[coord.x, coord.y] = currentBlock.color.ToArgb();
                        }
                    }
                }
            }
        }

        #region gameEvents

        /// <summary>
        /// Checks each of the rows and removes it if it's full, starting at the top and moving down.
        /// </summary>
        private void manageFullRows()
        {
            for (int row = hiddenRows; row < numberOfRowsTotal; row++)
                manageFullRow(row);
        }

        /// <summary>
        /// Checks to see whether a specified row is full.
        /// If it is, deletes the row and moves down the board above it.
        /// </summary>
        /// <param name="rowToCheck">The row in terms of board[col, row] to check</param>
        private void manageFullRow(int rowToCheck)
        {
            if (hasFullRow(rowToCheck))
                removeRow(rowToCheck);
        }

        /// <summary>
        /// Checks to see whether the specified row is full and should be removed
        /// </summary>
        /// <param name="rowToCheck">The row in terms of board[col, row] to check</param>
        /// <returns>Whether the specified row is full</returns>
        private Boolean hasFullRow(int rowToCheck)
        {
            Boolean full = true;

            for (int col = 0; col < numberOfColumns; col++)
            {
                if (board[col, rowToCheck] == boardColor)
                    full = false;
            }

            return full;
        }

        /// <summary>
        /// Removes a row from the game board and drops the remaining squares down from above
        /// </summary>
        /// <param name="row">The row in terms of board[col, row] to remove</param>
        private void removeRow(int rowToRemove)
        {
            if (rowToRemove == 0)
                return;

            // start on the specified row and move up
            for (int row = rowToRemove; row > 0; row--)
            {
                // passing through each column
                for (int col = 0; col < numberOfColumns; col++)
                {
                    // and overwriting the current position with the one above
                    board[col, row] = board[col, row - 1];
                }
            }
        }

        #endregion gameEvents

        #region blockMovement

        /// <summary>
        /// Rotates the block 90 degrees clockwise
        /// </summary>
        public void rotateBlock()
        {
            Block rotated = currentBlock.Clone();
            rotated.rotateClockwise();
            if (canBeHere(rotated))
                currentBlock.rotateClockwise();
        }

        /// <summary>
        /// Lowers the current block down one row
        /// </summary>
        public void lowerBlock()
        {
            if (canDropFurther())
            {
                currentBlock.y++;
            }
        }

        /// <summary>
        /// Moves the block left one column
        /// </summary>
        public void moveBlockLeft()
        {
            if (!hasBlockToSide(false))
            {
                currentBlock.x--;
            }
            trapBlock();
        }

        /// <summary>
        /// Moves the block right one column
        /// </summary>
        public void moveBlockRight()
        {
            if (!hasBlockToSide(true))
            {
                currentBlock.x++;
            }
            trapBlock();
        }

        /// <summary>
        /// Traps the block within the bounds of the arena
        /// </summary>
        private void trapBlock()
        {
            // find where the block's bounds are
            int leftest = currentBlock.leftestColumnWithSquareIn();
            int rightest = currentBlock.rightestColumnWithSquareIn();
            Coordinate leftestCoord = new Coordinate(leftest, 0);
            leftestCoord = currentBlock.toBoardCoordinates(leftestCoord);
            Coordinate rightestCoord = new Coordinate(rightest, 0);
            rightestCoord = currentBlock.toBoardCoordinates(rightestCoord);

            // trap it
            if (leftestCoord.x < 0)
                currentBlock.x++;
            if (rightestCoord.x >= numberOfColumns)
                currentBlock.x--;
        }

        #endregion blockMovement

        #region blockPositionChecks

        /// <summary>
        /// Checks to see whether there is a square in the specified position on the Board
        /// </summary>
        /// <param name="coord">The coordinate to check</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquare(Coordinate coord)
        {
            Boolean hasSquare = false;

            if (coord.x < numberOfColumns && coord.x >= 0 &&
                coord.y < numberOfRowsTotal && coord.y >= 0 &&
                        board[coord.x, coord.y] != boardColor)
            {
                hasSquare = true;
            }

            return hasSquare;
        }

        /// <summary>
        /// Checks to see whether there is a square in the position on the Board below the specified coordinate
        /// </summary>
        /// <param name="coord">The coordinate to check below</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquareBelow(Coordinate coord)
        {
            coord.y++;

            return hasSquare(coord);
        }

        /// <summary>
        /// Checks to see whether there is a square in the position on the Board left of the specified coordinate
        /// </summary>
        /// <param name="coord">The coordinate to check left of</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquareToLeft(Coordinate coord)
        {
            coord.x--;

            return hasSquare(coord);
        }

        /// <summary>
        /// Checks to see whether there is a square in the position on the Board right of the specified coordinate
        /// </summary>
        /// <param name="coord">The coordinate to check right of</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquareToRight(Coordinate coord)
        {
            coord.x++;

            return hasSquare(coord);
        }

        /// <summary>
        /// Checks to see whether the block is allowed to be in the specified position
        /// </summary>
        /// <param name="block">The block to check</param>
        /// <returns>Whether the block is allowed to be there</returns>
        private Boolean canBeHere(Block block)
        {
            Boolean canBeHere = true;

            // loop through each of the squares within the current block
            for (int col = 0; col < block.squares.GetLength(0); col++)
            {
                for (int row = 0; row < block.squares.GetLength(1); row++)
                {
                    // if there's something there
                    if (block.squares[row, col])
                    {
                        // check to see if there's something already here
                        Coordinate coord = block.toBoardCoordinates(new Coordinate(col, row));
                        if (hasSquare(coord) || coord.x >= numberOfColumns || coord.x < 0
                                || coord.y >= numberOfRowsTotal)
                        {
                            canBeHere = false;
                        }
                    }
                }
            }

            return canBeHere;
        }

        #endregion blockPositionChecks

        #endregion Board

        #region Block

        /// <summary>
        /// Checks to see whether the block can drop any futher
        /// </summary>
        /// <returns>Indicates whether the current block can drop any further</returns>
        private Boolean canDropFurther()
        {
            Boolean canDrop = true;

            /*
            Block dropped = currentBlock.Clone();
            dropped.y++;

            if (!canBeHere(dropped))
                canDrop = false;
            */

            if (blockIsOnBottom() || blockIsOnPile())
            {
                canDrop = false;
            }

            return canDrop;
        }

        /// <summary>
        /// Checks to see whether the block is on the bottom of the board
        /// </summary>
        /// <returns>Indicates whether the current block is on the bottom of the board</returns>
        private Boolean blockIsOnBottom()
        {
            Boolean onBottom = false;
            int lowestRow = currentBlock.lowestRowWithSquareIn();
            Coordinate coord = new Coordinate(0, lowestRow);
            coord = currentBlock.toBoardCoordinates(coord);
            if(coord.y - 1 >= numberOfRows)
            {
                onBottom = true;
            }

            return onBottom;
        }

        /// <summary>
        /// Checks to see whether the block is on the pile of blocks at the bottom of the board
        /// </summary>
        /// <returns>Indicates whether the current block is on the pile of blocks at the bottom of the board</returns>
        private Boolean blockIsOnPile()
        {
            Boolean onPile = false;

            // loop through each of the squares within the current block
            for (int col = 0; col < currentBlock.squares.GetLength(0); col++)
            {
                for (int row = 0; row < currentBlock.squares.GetLength(1); row++)
                {
                    // if there's something there
                    if (currentBlock.squares[row, col])
                    {
                        // check to see if there's anything below
                        Coordinate coord = currentBlock.toBoardCoordinates(new Coordinate(col, row));
                        if (hasSquareBelow(coord))
                        {
                            onPile = true;
                        }
                    }
                }
            }

            return onPile;
        }

        /// <summary>
        /// Checks to see whether there's something in the way to one side of the block
        /// </summary>
        /// <returns>Indicates whether the current block would be free to move to the specified side</returns>
        private Boolean hasBlockToSide(Boolean toRight)
        {
            Boolean obstruction = false;

            /*Block moved = currentBlock.Clone();
            if (toRight)
                moved.x++;
            else
                moved.x--;
            if (!canBeHere(moved))
                obstruction = true;*/

            // loop through each of the squares within the current block
            
            for (int col = 0; col < currentBlock.squares.GetLength(0); col++)
            {
                for (int row = 0; row < currentBlock.squares.GetLength(1); row++)
                {
                    // if there's something there
                    if (currentBlock.squares[row, col])
                    {
                        // check to see if there's anything in the way
                        Coordinate coord = currentBlock.toBoardCoordinates(new Coordinate(col, row));
                        if ((toRight && hasSquareToRight(coord)) || (!toRight && hasSquareToLeft(coord)))
                        {
                            obstruction = true;
                        }
                    }
                }
            }
            

            return obstruction;
        }

        #endregion Block
    }
}
