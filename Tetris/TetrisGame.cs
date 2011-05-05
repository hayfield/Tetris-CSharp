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
        /// The number of visible columns on the board
        /// </summary>
        int numberOfColumns = 10;

        /// <summary>
        /// The number of visible rows on the board
        /// </summary>
        int numberOfRows = 20;

        /// <summary>
        /// The size in px of each side of the squares
        /// </summary>
        int squareDimensions = 20;

        /// <summary>
        /// The squares that are visible on the board
        /// </summary>
        Dictionary<string, Square> squares = new Dictionary<string,Square>();

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
            board = new Board(numberOfRows, numberOfColumns);
            tickTimer.Enabled = true;
            playing = true;
        }

        /// <summary>
        /// Creates the squares which make up the visible portion of the board
        /// </summary>
        private void createSquares()
        {
            //squares = new Square[gameTable.RowCount, gameTable.ColumnCount];
            List<string> keys = new List<string>();
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    Square square = new Square(row, col);
                    square.Width = squareDimensions;
                    square.Height = squareDimensions;
                    square.Parent = gameWindow;
                    square.Top = row * squareDimensions;
                    square.Left = col * squareDimensions;
                    string key = row.ToString() + col.ToString();
                    squares.Add(key, square);
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
            // updates the color of each of the squares on the board
            Square square;
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    squares.TryGetValue(row.ToString() + col.ToString(), out square);
                    square.color = board.board[col, row + board.hiddenRows];
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

    }
}
