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
        /// Ticks the board forward one move
        /// </summary>
        public void tick()
        {
            if (currentBlock == null || !canDropFurther())
            {
                spawnBlock();
            }
        }

        /// <summary>
        /// Creates a new block to play with
        /// </summary>
        public void spawnBlock()
        {
            currentBlock = new Block();
        }

        /// <summary>
        /// Checks to see whether the block can drop any futher
        /// </summary>
        /// <returns>Indicates whether the current block can drop any further</returns>
        public Boolean canDropFurther()
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
        public Boolean blockIsOnBottom()
        {
            Boolean onBottom = false;

            if (currentBlock.x + currentBlock.lowestRowWithSquareIn() > board.GetLength(0) - 1)
            {
                onBottom = true;
            }

            return onBottom;
        }

        /// <summary>
        /// Checks to see whether the block is on the pile of blocks at the bottom of the board
        /// </summary>
        /// <returns>Indicates whether the current block is on the pile of blocks at the bottom of the board</returns>
        public Boolean blockIsOnPile()
        {
            Boolean onPile = false;

            return onPile;
        }
    }
}
