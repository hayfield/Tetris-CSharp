using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    /// <summary>
    /// A block (tetromino) that falls down the grid
    /// </summary>
    class Block
    {
        /// <summary>
        /// A block (tetromino) that falls down the grid
        /// </summary>
        /// <param name="positionSpawner">The position spawner to determine which block it should be</param>
        public Block(BlockPositionSpawner positionSpawner)
        {
            // decide which block it is
            Random random = new Random();
            BlockStartPosition startPos = positionSpawner.Next();
            squares = startPos.position;
            color = startPos.color;

            // set the initial position
            x = 3;
            y = 0;
        }

        #region variables

        /// <summary>
        /// The color of the block
        /// </summary>
        public Color color { get; set; }

        /// <summary>
        /// The position of squares and blanks within the block.
        /// squares[row, col]. Col = 0, Row = 1 for GetLength()
        /// Not consistent with the board, but it makes the visualisations for
        /// the starting positions clearer.
        /// </summary>
        public Boolean[,] squares;

        /// <summary>
        /// The x coordinate of the block
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// The y coordinate of the block
        /// </summary>
        public int y { get; set; }

        #endregion variables

        #region utility

        /// <summary>
        /// Clones the current block
        /// </summary>
        /// <returns>A clone of the current block</returns>
        public Block Clone()
        {
            return (Block)this.MemberwiseClone();
        }

        /// <summary>
        /// Converts the coordinates of a square within the block to board-coodinate space
        /// </summary>
        /// <returns></returns>
        public Coordinate toBoardCoordinates(Coordinate coord)
        {
            coord.x += x;
            coord.y += y;

            return coord;
        }

        /// <summary>
        /// Determines whether the block has a single solid cell
        /// </summary>
        public bool isSingleCell()
        {
            int count = 0;

            for (int col = 0; col < squares.GetLength(0); col++)
                for (int row = 0; row < squares.GetLength(1); row++)
                    if (squares[col, row])
                        count++;

            return count == 1;
        }

        #endregion utility

        #region movement

        /// <summary>
        /// Rotates the block clockwise
        /// </summary>
        public void rotateClockwise()
        {
            rotateAntiClockwise();
            rotateAntiClockwise();
            rotateAntiClockwise();
        }

        /// <summary>
        /// Rotates the block anti-clockwise by rotating it clockwise three times
        /// </summary>
        public void rotateAntiClockwise()
        {
            // would be quicker to use matrices, but thinking is hard ;P
            Boolean[,] temp = new Boolean[squares.GetLength(0), squares.GetLength(1)];

            // works for squares of size 4x4, so hopefully also works for bigger ones
            for (int col = 0; col < squares.GetLength(0); col++)
                for (int row = 0; row < squares.GetLength(1); row++)
                    temp[squares.GetLength(1) - 1 - row, col] = squares[col, row];

            squares = temp;
        }

        #endregion movement

        #region positionChecks

        /// <summary>
        /// Finds the columns with the lowest squares in
        /// </summary>
        /// <returns>A list of integers containing the columns with the lowest squares in</returns>
        public List<int> columnsWithLowestSquaresIn()
        {
            List<int> lowestColumns = new List<int>();
            int lowestRow = lowestRowWithSquareIn();

            for (int col = 0; col < squares.GetLength(0); col++)
                if (squares[col, lowestRow])
                    lowestColumns.Add(col);

            return lowestColumns;
        }

        /// <summary>
        /// Finds the lowest row with a square in
        /// </summary>
        /// <returns>The lowest row with a square in</returns>
        public int lowestRowWithSquareIn()
        {
            int lowestRow = 0;

            for (int col = 0; col < squares.GetLength(0); col++)
                for (int row = 0; row < squares.GetLength(1); row++)
                    if (squares[row, col])
                        lowestRow = row;

            return lowestRow;
        }

        /// <summary>
        /// Finds the row furthest to the left with a square in
        /// </summary>
        /// <returns>The row furthest to the left with a square in</returns>
        public int leftestColumnWithSquareIn()
        {
            int leftestCol = 0;

            for (int col = squares.GetLength(0) - 1; col >=0 ; col--)
                for (int row = 0; row < squares.GetLength(1); row++)
                    if (squares[row, col])
                        leftestCol = col;

            return leftestCol;
        }

        /// <summary>
        /// Finds the row furthest to the right with a square in
        /// </summary>
        /// <returns>The row furthest to the right with a square in</returns>
        public int rightestColumnWithSquareIn()
        {
            int rightestCol = 0;

            for (int col = 0; col < squares.GetLength(0); col++)
                for (int row = 0; row < squares.GetLength(1); row++)
                    if (squares[row, col])
                        rightestCol = col;

            return rightestCol;
        }

        #endregion positionChecks

    }
}
