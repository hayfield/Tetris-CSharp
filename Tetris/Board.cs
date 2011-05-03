using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /// <summary>
    /// The game board
    /// </summary>
    class Board
    {
        /// <summary>
        /// The board that is being played on
        /// </summary>
        int[,] board = new int[10,22];

        /// <summary>
        /// The block that is currently being played
        /// </summary>
        Block currentBlock;

        /// <summary>
        /// Creates a new block to play with
        /// </summary>
        public void newBlock()
        {
            currentBlock = new Block();
        }
    }
}
