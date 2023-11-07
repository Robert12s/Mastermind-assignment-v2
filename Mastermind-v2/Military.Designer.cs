namespace Mastermind_v2
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
            this.answerGrid = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid1 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid2 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid3 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid4 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid5 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid6 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid7 = new System.Windows.Forms.TableLayoutPanel();
            this.clueGrid8 = new System.Windows.Forms.TableLayoutPanel();
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
            // answerGrid
            // 
            this.answerGrid.BackColor = System.Drawing.Color.Transparent;
            this.answerGrid.ColumnCount = 4;
            this.answerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.answerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.answerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.answerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.answerGrid.Location = new System.Drawing.Point(38, 30);
            this.answerGrid.Name = "answerGrid";
            this.answerGrid.RowCount = 1;
            this.answerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.answerGrid.Size = new System.Drawing.Size(176, 44);
            this.answerGrid.TabIndex = 13;
            // 
            // clueGrid1
            // 
            this.clueGrid1.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid1.ColumnCount = 2;
            this.clueGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid1.Location = new System.Drawing.Point(336, 105);
            this.clueGrid1.Name = "clueGrid1";
            this.clueGrid1.RowCount = 2;
            this.clueGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid1.Size = new System.Drawing.Size(65, 65);
            this.clueGrid1.TabIndex = 14;
            // 
            // clueGrid2
            // 
            this.clueGrid2.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid2.ColumnCount = 2;
            this.clueGrid2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid2.Location = new System.Drawing.Point(336, 177);
            this.clueGrid2.Name = "clueGrid2";
            this.clueGrid2.RowCount = 2;
            this.clueGrid2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid2.Size = new System.Drawing.Size(65, 65);
            this.clueGrid2.TabIndex = 15;
            // 
            // clueGrid3
            // 
            this.clueGrid3.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid3.ColumnCount = 2;
            this.clueGrid3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid3.Location = new System.Drawing.Point(336, 249);
            this.clueGrid3.Name = "clueGrid3";
            this.clueGrid3.RowCount = 2;
            this.clueGrid3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid3.Size = new System.Drawing.Size(65, 65);
            this.clueGrid3.TabIndex = 16;
            // 
            // clueGrid4
            // 
            this.clueGrid4.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid4.ColumnCount = 2;
            this.clueGrid4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid4.Location = new System.Drawing.Point(336, 323);
            this.clueGrid4.Name = "clueGrid4";
            this.clueGrid4.RowCount = 2;
            this.clueGrid4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid4.Size = new System.Drawing.Size(65, 65);
            this.clueGrid4.TabIndex = 17;
            // 
            // clueGrid5
            // 
            this.clueGrid5.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid5.ColumnCount = 2;
            this.clueGrid5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid5.Location = new System.Drawing.Point(336, 399);
            this.clueGrid5.Name = "clueGrid5";
            this.clueGrid5.RowCount = 2;
            this.clueGrid5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid5.Size = new System.Drawing.Size(65, 65);
            this.clueGrid5.TabIndex = 18;
            // 
            // clueGrid6
            // 
            this.clueGrid6.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid6.ColumnCount = 2;
            this.clueGrid6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid6.Location = new System.Drawing.Point(336, 472);
            this.clueGrid6.Name = "clueGrid6";
            this.clueGrid6.RowCount = 2;
            this.clueGrid6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid6.Size = new System.Drawing.Size(65, 65);
            this.clueGrid6.TabIndex = 19;
            // 
            // clueGrid7
            // 
            this.clueGrid7.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid7.ColumnCount = 2;
            this.clueGrid7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid7.Location = new System.Drawing.Point(336, 544);
            this.clueGrid7.Name = "clueGrid7";
            this.clueGrid7.RowCount = 2;
            this.clueGrid7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid7.Size = new System.Drawing.Size(65, 65);
            this.clueGrid7.TabIndex = 20;
            // 
            // clueGrid8
            // 
            this.clueGrid8.BackColor = System.Drawing.Color.Transparent;
            this.clueGrid8.ColumnCount = 2;
            this.clueGrid8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid8.Location = new System.Drawing.Point(336, 616);
            this.clueGrid8.Name = "clueGrid8";
            this.clueGrid8.RowCount = 2;
            this.clueGrid8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clueGrid8.Size = new System.Drawing.Size(65, 65);
            this.clueGrid8.TabIndex = 21;
            // 
            // Military
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mastermind_v2.Properties.Resources.mastermind_pic1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 830);
            this.Controls.Add(this.clueGrid8);
            this.Controls.Add(this.clueGrid7);
            this.Controls.Add(this.clueGrid6);
            this.Controls.Add(this.clueGrid5);
            this.Controls.Add(this.clueGrid4);
            this.Controls.Add(this.clueGrid3);
            this.Controls.Add(this.clueGrid2);
            this.Controls.Add(this.clueGrid1);
            this.Controls.Add(this.answerGrid);
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
        private System.Windows.Forms.TableLayoutPanel answerGrid;
        private System.Windows.Forms.TableLayoutPanel clueGrid1;
        private System.Windows.Forms.TableLayoutPanel clueGrid2;
        private System.Windows.Forms.TableLayoutPanel clueGrid3;
        private System.Windows.Forms.TableLayoutPanel clueGrid4;
        private System.Windows.Forms.TableLayoutPanel clueGrid5;
        private System.Windows.Forms.TableLayoutPanel clueGrid6;
        private System.Windows.Forms.TableLayoutPanel clueGrid7;
        private System.Windows.Forms.TableLayoutPanel clueGrid8;
    }
}