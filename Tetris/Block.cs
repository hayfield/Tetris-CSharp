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
        /// The color of the block
        /// </summary>
        public Color color { get; set; }

        /// <summary>
        /// The type of the block
        /// </summary>
        public int type { get; set; }

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

        /// <summary>
        /// Has the block settled on the bottom of the grid?
        /// </summary>
        public Boolean settled { get; set; }

    }
}
