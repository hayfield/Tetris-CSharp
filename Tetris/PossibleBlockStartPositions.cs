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
            setPossiblePositions();
        }

        /// <summary>
        /// The possible positions that a block can start in
        /// </summary>
        BlockStartPosition[] positions = new BlockStartPosition[7];

        /// <summary>
        /// Specify the possible positions that a block can start in
        /// </summary>
        private void setPossiblePositions()
        {
            // straight across in a line
            positions[0] = new BlockStartPosition();
            positions[0].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, false},
                                        {true, true, true, true},
                                        {false, false, false, false}};
            positions[0].color = Color.Cyan;
            // L with a spike on the left
            positions[1] = new BlockStartPosition();
            positions[1].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, false, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            positions[1].color = Color.Blue;
            // L with a spike on the right
            positions[2] = new BlockStartPosition();
            positions[2].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, true},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            positions[2].color = Color.Orange;
            // square
            positions[3] = new BlockStartPosition();
            positions[3].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, true, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            positions[3].color = Color.Yellow;
            // zig-zag up to the right
            positions[4] = new BlockStartPosition();
            positions[4].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, true},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            positions[4].color = Color.Red;
            // zig-zag up to the left
            positions[5] = new BlockStartPosition();
            positions[5].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {true, true, false, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            positions[5].color = Color.Green;
            // T shape
            positions[6] = new BlockStartPosition();
            positions[6].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            positions[6].color = Color.Purple;
        }
    }
}
