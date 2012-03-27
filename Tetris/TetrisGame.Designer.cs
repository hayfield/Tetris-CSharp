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
            this.sqSizeSelect = new System.Windows.Forms.NumericUpDown();
            this.sqSizeLabel = new System.Windows.Forms.Label();
            this.boardColsSelect = new System.Windows.Forms.NumericUpDown();
            this.boardRowsSelect = new System.Windows.Forms.NumericUpDown();
            this.boardColsLabel = new System.Windows.Forms.Label();
            this.boardRowsLabel = new System.Windows.Forms.Label();
            this.blocksetList = new System.Windows.Forms.ComboBox();
            this.blocksetLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayout.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.upcomingBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqSizeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardColsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardRowsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.28835F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.71165F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
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
            this.tableLayout.Size = new System.Drawing.Size(656, 524);
            this.tableLayout.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(458, 441);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(61, 20);
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
            this.newGameButton.Location = new System.Drawing.Point(458, 375);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(195, 23);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // rowsClearedLabel
            // 
            this.rowsClearedLabel.AutoSize = true;
            this.rowsClearedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsClearedLabel.Location = new System.Drawing.Point(458, 408);
            this.rowsClearedLabel.Name = "rowsClearedLabel";
            this.rowsClearedLabel.Size = new System.Drawing.Size(58, 20);
            this.rowsClearedLabel.TabIndex = 4;
            this.rowsClearedLabel.Text = "Rows:";
            // 
            // rowsCleared
            // 
            this.rowsCleared.AutoSize = true;
            this.rowsCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsCleared.Location = new System.Drawing.Point(542, 408);
            this.rowsCleared.Name = "rowsCleared";
            this.rowsCleared.Size = new System.Drawing.Size(19, 20);
            this.rowsCleared.TabIndex = 5;
            this.rowsCleared.Text = "0";
            // 
            // gameWindow
            // 
            this.gameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameWindow.Location = new System.Drawing.Point(3, 30);
            this.gameWindow.Name = "gameWindow";
            this.tableLayout.SetRowSpan(this.gameWindow, 4);
            this.gameWindow.Size = new System.Drawing.Size(449, 491);
            this.gameWindow.TabIndex = 6;
            // 
            // upcomingBlocks
            // 
            this.tableLayout.SetColumnSpan(this.upcomingBlocks, 2);
            this.upcomingBlocks.Controls.Add(this.sqSizeSelect);
            this.upcomingBlocks.Controls.Add(this.sqSizeLabel);
            this.upcomingBlocks.Controls.Add(this.boardColsSelect);
            this.upcomingBlocks.Controls.Add(this.boardRowsSelect);
            this.upcomingBlocks.Controls.Add(this.boardColsLabel);
            this.upcomingBlocks.Controls.Add(this.boardRowsLabel);
            this.upcomingBlocks.Controls.Add(this.blocksetList);
            this.upcomingBlocks.Controls.Add(this.blocksetLabel);
            this.upcomingBlocks.Controls.Add(this.textBox2);
            this.upcomingBlocks.Controls.Add(this.textBox1);
            this.upcomingBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingBlocks.Location = new System.Drawing.Point(458, 30);
            this.upcomingBlocks.Name = "upcomingBlocks";
            this.upcomingBlocks.Size = new System.Drawing.Size(195, 339);
            this.upcomingBlocks.TabIndex = 7;
            // 
            // sqSizeSelect
            // 
            this.sqSizeSelect.Location = new System.Drawing.Point(118, 306);
            this.sqSizeSelect.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.sqSizeSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sqSizeSelect.Name = "sqSizeSelect";
            this.sqSizeSelect.ReadOnly = true;
            this.sqSizeSelect.Size = new System.Drawing.Size(68, 20);
            this.sqSizeSelect.TabIndex = 13;
            this.sqSizeSelect.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // sqSizeLabel
            // 
            this.sqSizeLabel.AutoSize = true;
            this.sqSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqSizeLabel.Location = new System.Drawing.Point(0, 306);
            this.sqSizeLabel.Name = "sqSizeLabel";
            this.sqSizeLabel.Size = new System.Drawing.Size(112, 20);
            this.sqSizeLabel.TabIndex = 12;
            this.sqSizeLabel.Text = "Square Size:";
            // 
            // boardColsSelect
            // 
            this.boardColsSelect.Location = new System.Drawing.Point(118, 276);
            this.boardColsSelect.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.boardColsSelect.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.boardColsSelect.Name = "boardColsSelect";
            this.boardColsSelect.ReadOnly = true;
            this.boardColsSelect.Size = new System.Drawing.Size(68, 20);
            this.boardColsSelect.TabIndex = 11;
            this.boardColsSelect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // boardRowsSelect
            // 
            this.boardRowsSelect.Location = new System.Drawing.Point(118, 244);
            this.boardRowsSelect.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.boardRowsSelect.Name = "boardRowsSelect";
            this.boardRowsSelect.ReadOnly = true;
            this.boardRowsSelect.Size = new System.Drawing.Size(68, 20);
            this.boardRowsSelect.TabIndex = 10;
            this.boardRowsSelect.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // boardColsLabel
            // 
            this.boardColsLabel.AutoSize = true;
            this.boardColsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardColsLabel.Location = new System.Drawing.Point(0, 276);
            this.boardColsLabel.Name = "boardColsLabel";
            this.boardColsLabel.Size = new System.Drawing.Size(102, 20);
            this.boardColsLabel.TabIndex = 9;
            this.boardColsLabel.Text = "Board Cols:";
            // 
            // boardRowsLabel
            // 
            this.boardRowsLabel.AutoSize = true;
            this.boardRowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardRowsLabel.Location = new System.Drawing.Point(0, 244);
            this.boardRowsLabel.Name = "boardRowsLabel";
            this.boardRowsLabel.Size = new System.Drawing.Size(111, 20);
            this.boardRowsLabel.TabIndex = 8;
            this.boardRowsLabel.Text = "Board Rows:";
            // 
            // blocksetList
            // 
            this.blocksetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blocksetList.FormattingEnabled = true;
            this.blocksetList.Location = new System.Drawing.Point(32, 211);
            this.blocksetList.Name = "blocksetList";
            this.blocksetList.Size = new System.Drawing.Size(129, 21);
            this.blocksetList.TabIndex = 7;
            // 
            // blocksetLabel
            // 
            this.blocksetLabel.AutoSize = true;
            this.blocksetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocksetLabel.Location = new System.Drawing.Point(3, 188);
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
            this.score.Location = new System.Drawing.Point(542, 441);
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
            // TetrisGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 524);
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
            ((System.ComponentModel.ISupportInitialize)(this.sqSizeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardColsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardRowsSelect)).EndInit();
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
        private System.Windows.Forms.Label boardRowsLabel;
        private System.Windows.Forms.NumericUpDown boardColsSelect;
        private System.Windows.Forms.NumericUpDown boardRowsSelect;
        private System.Windows.Forms.Label boardColsLabel;
        private System.Windows.Forms.NumericUpDown sqSizeSelect;
        private System.Windows.Forms.Label sqSizeLabel;

    }
}

