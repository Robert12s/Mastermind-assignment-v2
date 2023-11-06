﻿namespace Mastermind_v2
{
    partial class Military
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Military));
            this.countdownTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.purpleDot = new System.Windows.Forms.PictureBox();
            this.blueDot = new System.Windows.Forms.PictureBox();
            this.greenDot = new System.Windows.Forms.PictureBox();
            this.yellowDot = new System.Windows.Forms.PictureBox();
            this.orangeDot = new System.Windows.Forms.PictureBox();
            this.redDot = new System.Windows.Forms.PictureBox();
            this.boardGrid = new System.Windows.Forms.TableLayoutPanel();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purpleDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).BeginInit();
            this.SuspendLayout();
            // 
            // countdownTimer
            // 
            this.countdownTimer.BackColor = System.Drawing.Color.LemonChiffon;
            this.countdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTimer.Location = new System.Drawing.Point(277, 30);
            this.countdownTimer.Name = "countdownTimer";
            this.countdownTimer.Size = new System.Drawing.Size(105, 44);
            this.countdownTimer.TabIndex = 0;
            this.countdownTimer.Text = "000";
            this.countdownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // purpleDot
            // 
            this.purpleDot.BackColor = System.Drawing.Color.Transparent;
            this.purpleDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.purple;
            this.purpleDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purpleDot.Location = new System.Drawing.Point(338, 706);
            this.purpleDot.Name = "purpleDot";
            this.purpleDot.Size = new System.Drawing.Size(57, 56);
            this.purpleDot.TabIndex = 11;
            this.purpleDot.TabStop = false;
            this.purpleDot.UseWaitCursor = true;
            this.purpleDot.Click += new System.EventHandler(this.purpleDot_Click);
            // 
            // blueDot
            // 
            this.blueDot.BackColor = System.Drawing.Color.Transparent;
            this.blueDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.blue;
            this.blueDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueDot.Location = new System.Drawing.Point(277, 706);
            this.blueDot.Name = "blueDot";
            this.blueDot.Size = new System.Drawing.Size(57, 56);
            this.blueDot.TabIndex = 10;
            this.blueDot.TabStop = false;
            this.blueDot.UseWaitCursor = true;
            this.blueDot.Click += new System.EventHandler(this.blueDot_Click);
            // 
            // greenDot
            // 
            this.greenDot.BackColor = System.Drawing.Color.Transparent;
            this.greenDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.green;
            this.greenDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenDot.Location = new System.Drawing.Point(214, 706);
            this.greenDot.Name = "greenDot";
            this.greenDot.Size = new System.Drawing.Size(57, 56);
            this.greenDot.TabIndex = 9;
            this.greenDot.TabStop = false;
            this.greenDot.UseWaitCursor = true;
            this.greenDot.Click += new System.EventHandler(this.greenDot_Click);
            // 
            // yellowDot
            // 
            this.yellowDot.BackColor = System.Drawing.Color.Transparent;
            this.yellowDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.yellow;
            this.yellowDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowDot.Location = new System.Drawing.Point(155, 706);
            this.yellowDot.Name = "yellowDot";
            this.yellowDot.Size = new System.Drawing.Size(57, 56);
            this.yellowDot.TabIndex = 8;
            this.yellowDot.TabStop = false;
            this.yellowDot.UseWaitCursor = true;
            this.yellowDot.Click += new System.EventHandler(this.yellowDot_Click);
            // 
            // orangeDot
            // 
            this.orangeDot.BackColor = System.Drawing.Color.Transparent;
            this.orangeDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.orange;
            this.orangeDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeDot.Location = new System.Drawing.Point(93, 706);
            this.orangeDot.Name = "orangeDot";
            this.orangeDot.Size = new System.Drawing.Size(57, 56);
            this.orangeDot.TabIndex = 7;
            this.orangeDot.TabStop = false;
            this.orangeDot.UseWaitCursor = true;
            this.orangeDot.Click += new System.EventHandler(this.orangeDot_Click);
            // 
            // redDot
            // 
            this.redDot.BackColor = System.Drawing.Color.Transparent;
            this.redDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.red;
            this.redDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redDot.Location = new System.Drawing.Point(30, 706);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(57, 56);
            this.redDot.TabIndex = 6;
            this.redDot.TabStop = false;
            this.redDot.UseWaitCursor = true;
            this.redDot.Click += new System.EventHandler(this.redDot_Click);
            // 
            // boardGrid
            // 
            this.boardGrid.BackColor = System.Drawing.Color.Transparent;
            this.boardGrid.ColumnCount = 4;
            this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.boardGrid.Location = new System.Drawing.Point(21, 105);
            this.boardGrid.Margin = new System.Windows.Forms.Padding(0);
            this.boardGrid.Name = "boardGrid";
            this.boardGrid.RowCount = 8;
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.boardGrid.Size = new System.Drawing.Size(304, 584);
            this.boardGrid.TabIndex = 12;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Black;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(20, 775);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(150, 35);
            this.check.TabIndex = 0;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Military
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mastermind_v2.Properties.Resources.mastermind_pic1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 830);
            this.Controls.Add(this.check);
            this.Controls.Add(this.boardGrid);
            this.Controls.Add(this.purpleDot);
            this.Controls.Add(this.blueDot);
            this.Controls.Add(this.greenDot);
            this.Controls.Add(this.yellowDot);
            this.Controls.Add(this.orangeDot);
            this.Controls.Add(this.redDot);
            this.Controls.Add(this.countdownTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Military";
            this.Text = "Military";
            this.Load += new System.EventHandler(this.Military_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purpleDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label countdownTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox purpleDot;
        private System.Windows.Forms.PictureBox blueDot;
        private System.Windows.Forms.PictureBox greenDot;
        private System.Windows.Forms.PictureBox yellowDot;
        private System.Windows.Forms.PictureBox orangeDot;
        private System.Windows.Forms.PictureBox redDot;
        private System.Windows.Forms.TableLayoutPanel boardGrid;
        private System.Windows.Forms.Button check;
    }
}