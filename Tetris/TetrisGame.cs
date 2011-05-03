using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tetris;

namespace Tetris
{
    public partial class TetrisGame : Form
    {
        /// <summary>
        /// The possible positions that a block can start in
        /// </summary>
        BlockStartPosition[] possibleBlockPositions = new BlockStartPosition[7];

        /// <summary>
        /// Is a game currently being played?
        /// </summary>
        Boolean playing { get; set; }

        public TetrisGame()
        {
            setPossibleBlockPositions();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Specify the possible positions that a block can start in
        /// </summary>
        private void setPossibleBlockPositions()
        {
            // straight across in a line
            possibleBlockPositions[0] = new BlockStartPosition();
            possibleBlockPositions[0].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, false},
                                        {true, true, true, true},
                                        {false, false, false, false}};
            possibleBlockPositions[0].color = Color.Cyan;
            // L with a spike on the left
            possibleBlockPositions[1] = new BlockStartPosition();
            possibleBlockPositions[1].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, false, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            possibleBlockPositions[1].color = Color.Blue;
            // L with a spike on the right
            possibleBlockPositions[2] = new BlockStartPosition();
            possibleBlockPositions[2].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, true},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            possibleBlockPositions[2].color = Color.Orange;
            // square
            possibleBlockPositions[3] = new BlockStartPosition();
            possibleBlockPositions[3].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, true, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            possibleBlockPositions[3].color = Color.Yellow;
            // zig-zag up to the right
            possibleBlockPositions[4] = new BlockStartPosition();
            possibleBlockPositions[4].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, true},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            possibleBlockPositions[4].color = Color.Red;
            // zig-zag up to the left
            possibleBlockPositions[5] = new BlockStartPosition();
            possibleBlockPositions[5].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {true, true, false, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            possibleBlockPositions[5].color = Color.Green;
            // T shape
            possibleBlockPositions[6] = new BlockStartPosition();
            possibleBlockPositions[6].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            possibleBlockPositions[6].color = Color.Purple;
        }
    }
}
