using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /// <summary>
    /// A coordinate in the form (x, y)
    /// </summary>
    class Coordinate
    {
        /// <summary>
        /// Create a new coordinate in the form (x, y)
        /// </summary>
        /// <param name="x">The x-coordinate</param>
        /// <param name="y">The y-coordinate</param>
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// The x-coordinate
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// The y-coordinate
        /// </summary>
        public int y { get; set; }
    }
}
