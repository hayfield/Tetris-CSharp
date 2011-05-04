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
        /// Is a game currently being played?
        /// </summary>
        Boolean playing { get; set; }

        /// <summary>
        /// The board that the game is played on
        /// </summary>
        Board board;

        public TetrisGame()
        {
            InitializeComponent();
            createSquares();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Resets the game
        /// </summary>
        private void resetGame()
        {
            board = new Board();
        }

        /// <summary>
        /// Creates the squares which make up the visible portion of the board
        /// </summary>
        private void createSquares()
        {
            for (int row = 0; row < gameTable.RowCount; row++)
            {
                for (int col = 0; col < gameTable.ColumnCount; col++)
                {
                    Square square = new Square();
                    square.Dock = DockStyle.Fill;
                    square.Margin = Padding.Empty;
                    gameTable.Controls.Add(square, row, col);
                }
            }
        }

        /// <summary>
        /// Update the game at the interval that is specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tickTimer_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                board.tick();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

    }
}
