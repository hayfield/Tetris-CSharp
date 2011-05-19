﻿using System;
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
        /// Constructor
        /// </summary>
        public Input()
        {
            leftKeyPressed = false;
            rightKeyPressed = false;
            rotateKeyPressed = false;
            downKeyPressed = false;
        }

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

        /// <summary>
        /// Indicates whether the left key is pressed or not
        /// </summary>
        public Boolean leftKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the right key is pressed or not
        /// </summary>
        public Boolean rightKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the rotate key is pressed or not
        /// </summary>
        public Boolean rotateKeyPressed { get; set; }

        /// <summary>
        /// Indicates whether the down key is pressed or not
        /// </summary>
        public Boolean downKeyPressed { get; set; }
    }
}
