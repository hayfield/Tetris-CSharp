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
        public Board(int numberOfRows, int numberOfColumns)
        {
            board = new int[numberOfColumns, numberOfRows + hiddenRows];
            for (int col = 0; col < numberOfColumns; col++)
            {
                for (int row = 0; row < numberOfRows + hiddenRows; row++)
                {
                    board[col, row] = boardColor;
                }
            }
            tick(); // stop a crash when holding a key down when starting a game
        }

        #region variables

        /// <summary>
        /// The default color of the board when there are no blocks there
        /// </summary>
        int boardColor = Color.PeachPuff.ToArgb();

        /// <summary>
        /// The board that is being played on
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
                for (int i = 0; i < currentBlock.squares.GetLength(0); i++)
                {
                    for (int j = 0; j < currentBlock.squares.GetLength(1); j++)
                    {
                        // if there's something there
                        if (currentBlock.squares[j, i])
                        {
                            // lock it into position on the board
                            Coordinate coord = currentBlock.toBoardCoordinates(new Coordinate(i, j));
                            board[coord.x, coord.y] = currentBlock.color.ToArgb();
                        }
                    }
                }
            }
        }

        #region blockMovement

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
            
        }

        /// <summary>
        /// Moves the block right one column
        /// </summary>
        public void moveBlockRight()
        {

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

            if (coord.x < board.GetLength(0) && coord.x >= 0 &&
                coord.y < board.GetLength(1) && coord.y >= 0 &&
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
        private Boolean hasSquareLeft(Coordinate coord)
        {
            coord.x--;

            return hasSquare(coord);
        }

        /// <summary>
        /// Checks to see whether there is a square in the position on the Board right of the specified coordinate
        /// </summary>
        /// <param name="coord">The coordinate to check right of</param>
        /// <returns>Whether there is a square there or not</returns>
        private Boolean hasSquareRight(Coordinate coord)
        {
            coord.x++;

            return hasSquare(coord);
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
            int len0 = board.GetLength(1);
            int lowestRow = currentBlock.lowestRowWithSquareIn();
            Coordinate coord = new Coordinate(0, lowestRow);
            coord = currentBlock.toBoardCoordinates(coord);
            if(coord.y - 1 >= board.GetLength(1) - hiddenRows)
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
            for (int i = 0; i < currentBlock.squares.GetLength(0); i++)
            {
                for (int j = 0; j < currentBlock.squares.GetLength(1); j++)
                {
                    // if there's something there
                    if (currentBlock.squares[j, i])
                    {
                        // check to see if there's anything below
                        Coordinate coord = currentBlock.toBoardCoordinates(new Coordinate(i, j));
                        if (hasSquareBelow(coord))
                        {
                            onPile = true;
                        }
                    }
                }
            }

            return onPile;
        }

        #endregion Block
    }
}
