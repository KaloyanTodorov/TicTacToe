namespace TicTacToe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.XWins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.OWins = new System.Windows.Forms.Label();
            this.XWinsCount = new System.Windows.Forms.Label();
            this.DrawsCount = new System.Windows.Forms.Label();
            this.OWinsCount = new System.Windows.Forms.Label();
            this.resetWinCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.AutoEllipsis = true;
            this.A1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A1.Location = new System.Drawing.Point(12, 47);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A3
            // 
            this.A3.AutoEllipsis = true;
            this.A3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A3.Location = new System.Drawing.Point(174, 47);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A2
            // 
            this.A2.AutoEllipsis = true;
            this.A2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A2.Location = new System.Drawing.Point(93, 47);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B1
            // 
            this.B1.AutoEllipsis = true;
            this.B1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.B1.Location = new System.Drawing.Point(12, 128);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.MouseCaptureChanged += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B2
            // 
            this.B2.AutoEllipsis = true;
            this.B2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.B2.Location = new System.Drawing.Point(93, 128);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B3
            // 
            this.B3.AutoEllipsis = true;
            this.B3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.B3.Location = new System.Drawing.Point(174, 128);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C1
            // 
            this.C1.AutoEllipsis = true;
            this.C1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.C1.Location = new System.Drawing.Point(12, 209);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C2
            // 
            this.C2.AutoEllipsis = true;
            this.C2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.C2.Location = new System.Drawing.Point(93, 209);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C3
            // 
            this.C3.AutoEllipsis = true;
            this.C3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.C3.Location = new System.Drawing.Point(174, 209);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // XWins
            // 
            this.XWins.AutoSize = true;
            this.XWins.Location = new System.Drawing.Point(12, 287);
            this.XWins.Name = "XWins";
            this.XWins.Size = new System.Drawing.Size(48, 17);
            this.XWins.TabIndex = 11;
            this.XWins.Text = "X wins";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(107, 287);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(47, 17);
            this.Draws.TabIndex = 12;
            this.Draws.Text = "Draws";
            // 
            // OWins
            // 
            this.OWins.AutoSize = true;
            this.OWins.Location = new System.Drawing.Point(200, 287);
            this.OWins.Name = "OWins";
            this.OWins.Size = new System.Drawing.Size(50, 17);
            this.OWins.TabIndex = 13;
            this.OWins.Text = "O wins";
            // 
            // XWinsCount
            // 
            this.XWinsCount.AutoSize = true;
            this.XWinsCount.Location = new System.Drawing.Point(14, 310);
            this.XWinsCount.Name = "XWinsCount";
            this.XWinsCount.Size = new System.Drawing.Size(16, 17);
            this.XWinsCount.TabIndex = 14;
            this.XWinsCount.Text = "0";
            // 
            // DrawsCount
            // 
            this.DrawsCount.AutoSize = true;
            this.DrawsCount.Location = new System.Drawing.Point(107, 310);
            this.DrawsCount.Name = "DrawsCount";
            this.DrawsCount.Size = new System.Drawing.Size(16, 17);
            this.DrawsCount.TabIndex = 15;
            this.DrawsCount.Text = "0";
            // 
            // OWinsCount
            // 
            this.OWinsCount.AutoSize = true;
            this.OWinsCount.Location = new System.Drawing.Point(200, 310);
            this.OWinsCount.Name = "OWinsCount";
            this.OWinsCount.Size = new System.Drawing.Size(16, 17);
            this.OWinsCount.TabIndex = 16;
            this.OWinsCount.Text = "0";
            // 
            // resetWinCountsToolStripMenuItem
            // 
            this.resetWinCountsToolStripMenuItem.Name = "resetWinCountsToolStripMenuItem";
            this.resetWinCountsToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.resetWinCountsToolStripMenuItem.Text = "Reset win counts";
            this.resetWinCountsToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 336);
            this.Controls.Add(this.OWinsCount);
            this.Controls.Add(this.DrawsCount);
            this.Controls.Add(this.XWinsCount);
            this.Controls.Add(this.OWins);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.XWins);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label XWins;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Label OWins;
        private System.Windows.Forms.Label XWinsCount;
        private System.Windows.Forms.Label DrawsCount;
        private System.Windows.Forms.Label OWinsCount;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountsToolStripMenuItem;
    }
}

