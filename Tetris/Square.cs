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
        public Square()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The color of the square
        /// </summary>
        public int color
        {
            set
            {
                this.color = value;
                this.BackColor = Color.FromArgb(value);
            }
        }
    }
}
