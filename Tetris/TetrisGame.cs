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

        /// <summary>
        /// The squares that are visible on the board
        /// </summary>
        Square[,] squares;

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
            tickTimer.Enabled = true;
            playing = true;
        }

        /// <summary>
        /// Creates the squares which make up the visible portion of the board
        /// </summary>
        private void createSquares()
        {
            squares = new Square[gameTable.RowCount, gameTable.ColumnCount];

            for (int row = 0; row < gameTable.RowCount; row++)
            {
                for (int col = 0; col < gameTable.ColumnCount; col++)
                {
                    squares[row, col] = new Square(row, col);
                    squares[row, col].Dock = DockStyle.Fill;
                    squares[row, col].Margin = Padding.Empty;
                    gameTable.SetCellPosition(squares[row, col], new TableLayoutPanelCellPosition(col, row));
                    /*Square square = new Square(row, col);
                    square.Dock = DockStyle.Fill;
                    square.Margin = Padding.Empty;
                    gameTable.Controls.Add(square, row, col);*/
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
                updateBoard();
                rowsClearedLabel.Text = "playing " + DateTime.Now.Second.ToString();
            }
            else
            {
                rowsClearedLabel.Text = "rows: " + DateTime.Now.Second.ToString();
            }
        }

        /// <summary>
        /// Updates the game board, displaying where the squares are on the grid
        /// </summary>
        private void updateBoard()
        {
            Square square;
            for (int row = 0; row < gameTable.RowCount; row++)
            {
                for (int col = 0; col < gameTable.ColumnCount; col++)
                {
                    squares[row, col].BackColor = Color.FromArgb(board.board[row, col + board.hiddenRows]);
                    /*square = (Square)gameTable.Controls.Find("square" + row.ToString() + col.ToString(), true)[0];
                    square.BackColor = Color.FromArgb(board.board[row, col + board.hiddenRows]);
                    Square sq = new Square(2, 3);
                    sq.Parent = gameTable.SetCellPosition*/
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

    }
}
