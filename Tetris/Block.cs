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
