using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /// <summary>
    /// Specifies the keyboard keys that are pressed.
    /// </summary>
    class Input
    {
        /// <summary>
        /// The key to move the current block left
        /// </summary>
        public readonly char leftKey = 'a';

        /// <summary>
        /// The key to move the current block right
        /// </summary>
        public readonly char rightKey = 'd';

        /// <summary>
        /// The key to rotate the block 90 degrees clockwise
        /// </summary>
        public readonly char rotateKey = 'w';

        /// <summary>
        /// The key to move the block down one row
        /// </summary>
        public readonly char downKey = 's';
    }
}
