namespace Mastermind_v2
{
    partial class MilitaryMastermind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MilitaryMastermind));
            this.redDot = new System.Windows.Forms.PictureBox();
            this.orangeDot = new System.Windows.Forms.PictureBox();
            this.yellowDot = new System.Windows.Forms.PictureBox();
            this.greenDot = new System.Windows.Forms.PictureBox();
            this.blueDot = new System.Windows.Forms.PictureBox();
            this.purpleDot = new System.Windows.Forms.PictureBox();
            this.timerBomb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleDot)).BeginInit();
            this.SuspendLayout();
            // 
            // redDot
            // 
            this.redDot.BackColor = System.Drawing.Color.Transparent;
            this.redDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.red_circle_removebg_preview;
            this.redDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redDot.Location = new System.Drawing.Point(28, 667);
            this.redDot.Name = "redDot";
            this.redDot.Size = new System.Drawing.Size(57, 56);
            this.redDot.TabIndex = 0;
            this.redDot.TabStop = false;
            this.redDot.UseWaitCursor = true;
            this.redDot.Click += new System.EventHandler(this.redDot_Click);
            // 
            // orangeDot
            // 
            this.orangeDot.BackColor = System.Drawing.Color.Transparent;
            this.orangeDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.orange_circle_removebg_preview__2_;
            this.orangeDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeDot.Location = new System.Drawing.Point(91, 667);
            this.orangeDot.Name = "orangeDot";
            this.orangeDot.Size = new System.Drawing.Size(57, 56);
            this.orangeDot.TabIndex = 1;
            this.orangeDot.TabStop = false;
            this.orangeDot.UseWaitCursor = true;
            // 
            // yellowDot
            // 
            this.yellowDot.BackColor = System.Drawing.Color.Transparent;
            this.yellowDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.yellow_circle_removebg_preview;
            this.yellowDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowDot.Location = new System.Drawing.Point(153, 667);
            this.yellowDot.Name = "yellowDot";
            this.yellowDot.Size = new System.Drawing.Size(57, 56);
            this.yellowDot.TabIndex = 2;
            this.yellowDot.TabStop = false;
            this.yellowDot.UseWaitCursor = true;
            // 
            // greenDot
            // 
            this.greenDot.BackColor = System.Drawing.Color.Transparent;
            this.greenDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.green_circle_removebg_preview;
            this.greenDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenDot.Location = new System.Drawing.Point(214, 667);
            this.greenDot.Name = "greenDot";
            this.greenDot.Size = new System.Drawing.Size(57, 56);
            this.greenDot.TabIndex = 3;
            this.greenDot.TabStop = false;
            this.greenDot.UseWaitCursor = true;
            // 
            // blueDot
            // 
            this.blueDot.BackColor = System.Drawing.Color.Transparent;
            this.blueDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.blue_circle_removebg_preview;
            this.blueDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueDot.Location = new System.Drawing.Point(275, 667);
            this.blueDot.Name = "blueDot";
            this.blueDot.Size = new System.Drawing.Size(57, 56);
            this.blueDot.TabIndex = 4;
            this.blueDot.TabStop = false;
            this.blueDot.UseWaitCursor = true;
            // 
            // purpleDot
            // 
            this.purpleDot.BackColor = System.Drawing.Color.Transparent;
            this.purpleDot.BackgroundImage = global::Mastermind_v2.Properties.Resources.purple_circle_removebg_preview;
            this.purpleDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purpleDot.Location = new System.Drawing.Point(336, 667);
            this.purpleDot.Name = "purpleDot";
            this.purpleDot.Size = new System.Drawing.Size(57, 56);
            this.purpleDot.TabIndex = 5;
            this.purpleDot.TabStop = false;
            this.purpleDot.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seconds";
            // 
            // MilitaryMastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(32)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerBomb);
            this.Controls.Add(this.purpleDot);
            this.Controls.Add(this.blueDot);
            this.Controls.Add(this.greenDot);
            this.Controls.Add(this.yellowDot);
            this.Controls.Add(this.orangeDot);
            this.Controls.Add(this.redDot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MilitaryMastermind";
            this.Text = "Military Mastermind";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MilitaryMastermind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleDot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redDot;
        private System.Windows.Forms.PictureBox orangeDot;
        private System.Windows.Forms.PictureBox yellowDot;
        private System.Windows.Forms.PictureBox greenDot;
        private System.Windows.Forms.PictureBox blueDot;
        private System.Windows.Forms.PictureBox purpleDot;
        private System.Windows.Forms.Label timerBomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

