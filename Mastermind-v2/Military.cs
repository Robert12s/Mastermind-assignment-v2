using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_v2
{
    public partial class Military : Form
    {
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        int seconds;
        public Military()
        {
            InitializeComponent();

            seconds = Convert.ToInt32(10);
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
                //   
            }
            DisplayArray(answer);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countdownTimer.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer.Stop();
                gameOver newform = new gameOver();
                this.Hide();
                newform.ShowDialog();
                this.Show();
            }
        }
    }
}
