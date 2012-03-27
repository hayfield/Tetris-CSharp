namespace Tetris
{
    partial class TetrisGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameButton = new System.Windows.Forms.Button();
            this.rowsClearedLabel = new System.Windows.Forms.Label();
            this.rowsCleared = new System.Windows.Forms.Label();
            this.gameWindow = new System.Windows.Forms.Panel();
            this.upcomingBlocks = new System.Windows.Forms.Panel();
            this.blocksetLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.blocksetList = new System.Windows.Forms.ComboBox();
            this.tableLayout.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.upcomingBlocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.89474F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10526F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayout.Controls.Add(this.scoreLabel, 0, 4);
            this.tableLayout.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayout.Controls.Add(this.newGameButton, 1, 2);
            this.tableLayout.Controls.Add(this.rowsClearedLabel, 1, 3);
            this.tableLayout.Controls.Add(this.rowsCleared, 2, 3);
            this.tableLayout.Controls.Add(this.gameWindow, 0, 1);
            this.tableLayout.Controls.Add(this.upcomingBlocks, 1, 1);
            this.tableLayout.Controls.Add(this.score, 2, 4);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 5;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.857142F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(656, 506);
            this.tableLayout.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(488, 423);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(56, 40);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score:";
            // 
            // menuStrip
            // 
            this.tableLayout.SetColumnSpan(this.menuStrip, 4);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(656, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // newGameButton
            // 
            this.tableLayout.SetColumnSpan(this.newGameButton, 2);
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGameButton.Location = new System.Drawing.Point(488, 359);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(165, 23);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // rowsClearedLabel
            // 
            this.rowsClearedLabel.AutoSize = true;
            this.rowsClearedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsClearedLabel.Location = new System.Drawing.Point(488, 390);
            this.rowsClearedLabel.Name = "rowsClearedLabel";
            this.rowsClearedLabel.Size = new System.Drawing.Size(58, 20);
            this.rowsClearedLabel.TabIndex = 4;
            this.rowsClearedLabel.Text = "Rows:";
            // 
            // rowsCleared
            // 
            this.rowsCleared.AutoSize = true;
            this.rowsCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsCleared.Location = new System.Drawing.Point(554, 390);
            this.rowsCleared.Name = "rowsCleared";
            this.rowsCleared.Size = new System.Drawing.Size(19, 20);
            this.rowsCleared.TabIndex = 5;
            this.rowsCleared.Text = "0";
            // 
            // gameWindow
            // 
            this.gameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameWindow.Location = new System.Drawing.Point(3, 29);
            this.gameWindow.Name = "gameWindow";
            this.tableLayout.SetRowSpan(this.gameWindow, 4);
            this.gameWindow.Size = new System.Drawing.Size(479, 474);
            this.gameWindow.TabIndex = 6;
            // 
            // upcomingBlocks
            // 
            this.tableLayout.SetColumnSpan(this.upcomingBlocks, 2);
            this.upcomingBlocks.Controls.Add(this.blocksetList);
            this.upcomingBlocks.Controls.Add(this.blocksetLabel);
            this.upcomingBlocks.Controls.Add(this.textBox2);
            this.upcomingBlocks.Controls.Add(this.textBox1);
            this.upcomingBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingBlocks.Location = new System.Drawing.Point(488, 29);
            this.upcomingBlocks.Name = "upcomingBlocks";
            this.upcomingBlocks.Size = new System.Drawing.Size(165, 324);
            this.upcomingBlocks.TabIndex = 7;
            // 
            // blocksetLabel
            // 
            this.blocksetLabel.AutoSize = true;
            this.blocksetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocksetLabel.Location = new System.Drawing.Point(3, 217);
            this.blocksetLabel.Name = "blocksetLabel";
            this.blocksetLabel.Size = new System.Drawing.Size(83, 20);
            this.blocksetLabel.TabIndex = 5;
            this.blocksetLabel.Text = "Blockset:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(554, 423);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(19, 20);
            this.score.TabIndex = 9;
            this.score.Text = "0";
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 500;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // blocksetList
            // 
            this.blocksetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blocksetList.FormattingEnabled = true;
            this.blocksetList.Location = new System.Drawing.Point(11, 240);
            this.blocksetList.Name = "blocksetList";
            this.blocksetList.Size = new System.Drawing.Size(145, 21);
            this.blocksetList.TabIndex = 7;
            // 
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 506);
            this.Controls.Add(this.tableLayout);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TetrisGame";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TetrisGame_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TetrisGame_KeyUp);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.upcomingBlocks.ResumeLayout(false);
            this.upcomingBlocks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label rowsClearedLabel;
        private System.Windows.Forms.Label rowsCleared;
        private System.Windows.Forms.Panel gameWindow;
        private System.Windows.Forms.Panel upcomingBlocks;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label blocksetLabel;
        private System.Windows.Forms.ComboBox blocksetList;

    }
}

