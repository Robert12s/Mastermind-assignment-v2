using Mastermind_v2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_v2
{
    public partial class Military : Form
    {
        public int currentColumn;
        public int currentRow;
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        int val = 20;
        public Military()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Military_Load(object sender, EventArgs e)
        {
            string[] colourArray = { "red", "orange", "yellow", "green", "blue", "purple" };
            Random rondo = new Random();
            string[] answer = new string[5];

            for (int i = 0; i < 4; i++)
            {
                int num = rondo.Next(0, 6);
                answer[i] = colourArray[num];
                 
            }
            DisplayArray(answer);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int timeLeft = val--;
            countdownTimer.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                gameOver newform = new gameOver();
                this.Close();
                newform.ShowDialog();
            }

        }

        private void fill_board(string colourButton)
        {
            var cell = new PictureBox();

            cell.Dock = DockStyle.Fill;
            cell.Padding = new Padding();
            cell.Margin = new Padding(9,4,9,12);

            switch (colourButton)
            {
                case "red":
                    cell.BackgroundImage = Resources.red;
                    break;

                case "orange":
                    cell.BackgroundImage = Resources.orange;
                    break;

                case "yellow":
                    cell.BackgroundImage = Resources.yellow;
                    break;

                case "green":
                    cell.BackgroundImage = Resources.green;
                    break;

                case "blue":
                    cell.BackgroundImage = Resources.blue;
                    break;

                case "purple":
                    cell.BackgroundImage = Resources.purple;
                    break;
            }

            cell.BackgroundImageLayout = ImageLayout.Stretch;

            boardGrid.Controls.Add(cell, currentColumn, currentRow);

            if (currentColumn < 4)
            {
                currentColumn++;
            }
            else {
                currentColumn = 0;
                currentRow++;
            }

        }

        private void redDot_Click(object sender, EventArgs e)
        {
            fill_board("red");
        }

        private void orangeDot_Click(object sender, EventArgs e)
        {
            fill_board("orange");
        }

        private void yellowDot_Click(object sender, EventArgs e)
        {
            fill_board("yellow");
        }

        private void greenDot_Click(object sender, EventArgs e)
        {
            fill_board("green");
        }

        private void blueDot_Click(object sender, EventArgs e)
        {
            fill_board("blue");
        }

        private void purpleDot_Click(object sender, EventArgs e)
        {
            fill_board("purple");
        }

        private void check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checking Row now !!");
        }
    }
}
