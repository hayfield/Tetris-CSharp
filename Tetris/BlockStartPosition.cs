using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    /// <summary>
    /// Specifies a possible start position for a block
    /// </summary>
    class BlockStartPosition
    {
        /// <summary>
        /// The start position of the block
        /// </summary>
        public Boolean[,] position { get; set; }

        /// <summary>
        /// The color of the block - regulations specify that different shapes are different colors
        /// </summary>
        public Color color { get; set; }
    }
}
