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
        /// Constructor
        /// </summary>
        public Block()
        {
            // decide which block it is
            Random random = new Random();
            BlockStartPosition startPos = new BlockStartPosition();
            startPos = new PossibleBlockStartPositions().positions[random.Next(7)];
            squares = startPos.position;
            color = startPos.color;

            // set the initial position
            x = 3;
            y = 0;
        }

        /// <summary>
        /// Rotates the block clockwise
        /// </summary>
        public void rotateClockwise()
        {
            // would be quicker to use matrices, but thinking is hard ;P
            Boolean[,] temp = new Boolean[4, 4];
            temp[0,0] = squares[0,3];
            temp[1,0] = squares[0,2];
            temp[2,0] = squares[0,1];
            temp[3,0] = squares[0,0];
            temp[0,1] = squares[1,3];
            temp[1,1] = squares[1,2];
            temp[2,1] = squares[1,1];
            temp[3,1] = squares[1,0];
            temp[0,2] = squares[2,3];
            temp[1,2] = squares[2,2];
            temp[2,2] = squares[2,1];
            temp[3,2] = squares[2,0];
            temp[0,3] = squares[3,3];
            temp[1,3] = squares[3,2];
            temp[2,3] = squares[3,1];
            temp[3,3] = squares[3,0];

            squares = temp;
        }

        /// <summary>
        /// Rotates the block anti-clockwise by rotating it clockwise three times
        /// </summary>
        public void rotateAntiClockwise()
        {
            rotateClockwise();
            rotateClockwise();
            rotateClockwise();
        }

        /// <summary>
        /// The color of the block
        /// </summary>
        public Color color { get; set; }

        /// <summary>
        /// The position of squares and blanks within the block
        /// </summary>
        public Boolean[,] squares = new Boolean[4, 4];

        /// <summary>
        /// The x coordinate of the block
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// The y coordinate of the block
        /// </summary>
        public int y { get; set; }

    }
}
