using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    /// <summary>
    /// The possible positions that a block may start in
    /// </summary>
    class PossibleBlockStartPositions
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PossibleBlockStartPositions()
        {
            setPossiblePositions(currentBucket);
            setPossiblePositions(nextBucket);
        }

        /// <summary>
        /// The current bucket of blocks that should be taken from when selecting a new one
        /// </summary>
        public BlockStartPosition[] currentBucket = new BlockStartPosition[7];

        /// <summary>
        /// The next bucket of blocks that should be taken from when selecting a new one
        /// </summary>
        public BlockStartPosition[] nextBucket = new BlockStartPosition[7];

        /// <summary>
        /// Specify the possible positions that a block can start in
        /// </summary>
        private void setPossiblePositions(BlockStartPosition[] bucket)
        {
            // straight across in a line
            bucket[0] = new BlockStartPosition();
            bucket[0].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, false},
                                        {true, true, true, true},
                                        {false, false, false, false}};
            bucket[0].color = Color.Cyan;
            // L with a spike on the left
            bucket[1] = new BlockStartPosition();
            bucket[1].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, false, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[1].color = Color.Blue;
            // L with a spike on the right
            bucket[2] = new BlockStartPosition();
            bucket[2].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, true},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[2].color = Color.Orange;
            // square
            bucket[3] = new BlockStartPosition();
            bucket[3].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, true, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[3].color = Color.Yellow;
            // zig-zag up to the right
            bucket[4] = new BlockStartPosition();
            bucket[4].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, true},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[4].color = Color.Red;
            // zig-zag up to the left
            bucket[5] = new BlockStartPosition();
            bucket[5].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {true, true, false, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[5].color = Color.Green;
            // T shape
            bucket[6] = new BlockStartPosition();
            bucket[6].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[6].color = Color.Purple;
        }
    }
}
