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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameButton = new System.Windows.Forms.Button();
            this.rowsClearedLabel = new System.Windows.Forms.Label();
            this.rowsCleared = new System.Windows.Forms.Label();
            this.gameWindow = new System.Windows.Forms.Panel();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.upcomingBlocks = new System.Windows.Forms.Panel();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayout.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.gameWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.89474F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10526F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayout.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayout.Controls.Add(this.newGameButton, 1, 2);
            this.tableLayout.Controls.Add(this.rowsClearedLabel, 1, 3);
            this.tableLayout.Controls.Add(this.rowsCleared, 2, 3);
            this.tableLayout.Controls.Add(this.gameWindow, 0, 1);
            this.tableLayout.Controls.Add(this.upcomingBlocks, 1, 1);
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
            this.tableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.newGameButton.Location = new System.Drawing.Point(503, 359);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(150, 23);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            // 
            // rowsClearedLabel
            // 
            this.rowsClearedLabel.AutoSize = true;
            this.rowsClearedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsClearedLabel.Location = new System.Drawing.Point(503, 390);
            this.rowsClearedLabel.Name = "rowsClearedLabel";
            this.rowsClearedLabel.Size = new System.Drawing.Size(58, 20);
            this.rowsClearedLabel.TabIndex = 4;
            this.rowsClearedLabel.Text = "Rows:";
            // 
            // rowsCleared
            // 
            this.rowsCleared.AutoSize = true;
            this.rowsCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsCleared.Location = new System.Drawing.Point(571, 390);
            this.rowsCleared.Name = "rowsCleared";
            this.rowsCleared.Size = new System.Drawing.Size(19, 20);
            this.rowsCleared.TabIndex = 5;
            this.rowsCleared.Text = "0";
            // 
            // gameWindow
            // 
            this.gameWindow.Controls.Add(this.gameTable);
            this.gameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameWindow.Location = new System.Drawing.Point(3, 29);
            this.gameWindow.Name = "gameWindow";
            this.tableLayout.SetRowSpan(this.gameWindow, 4);
            this.gameWindow.Size = new System.Drawing.Size(494, 474);
            this.gameWindow.TabIndex = 6;
            // 
            // gameTable
            // 
            this.gameTable.ColumnCount = 10;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTable.Location = new System.Drawing.Point(0, 0);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 20;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.gameTable.Size = new System.Drawing.Size(494, 474);
            this.gameTable.TabIndex = 0;
            // 
            // upcomingBlocks
            // 
            this.tableLayout.SetColumnSpan(this.upcomingBlocks, 2);
            this.upcomingBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingBlocks.Location = new System.Drawing.Point(503, 29);
            this.upcomingBlocks.Name = "upcomingBlocks";
            this.upcomingBlocks.Size = new System.Drawing.Size(150, 324);
            this.upcomingBlocks.TabIndex = 7;
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
            this.ClientSize = new System.Drawing.Size(656, 506);
            this.Controls.Add(this.tableLayout);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TetrisGame";
            this.Text = "Tetris";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gameWindow.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Panel upcomingBlocks;
        private System.Windows.Forms.Timer tickTimer;

    }
}

