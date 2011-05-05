using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    /// <summary>
    /// A square to display on the Tetris board
    /// </summary>
    public partial class Square : UserControl
    {
        public Square(int row, int col)
        {
            InitializeComponent();
            this.Name = "square" + row.ToString() + col.ToString();
            this.row = row;
            this.column = col;
        }

        /// <summary>
        /// The name of the square
        /// </summary>
        public new string Name { get; set; }

        /// <summary>
        /// The row that the square is on
        /// </summary>
        public int row { get; set; }

        /// <summary>
        /// The column that the square is in
        /// </summary>
        public int column { get; set; }

        /// <summary>
        /// The color of the square
        /// </summary>
        public int color
        {
            set
            {
                // this.color = value;
                this.BackColor = Color.FromArgb(value);
            }
        }
    }
}
