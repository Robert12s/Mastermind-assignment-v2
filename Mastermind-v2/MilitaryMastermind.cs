using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_v2
{
    public partial class MilitaryMastermind : Form
    {
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        int seconds;
        public MilitaryMastermind()
        {
            InitializeComponent();

           seconds = Convert.ToInt32(480);
           timer.Start();
        }

        private void MilitaryMastermind_Load(object sender, EventArgs e)
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

        private void redDot_Click(object sender, EventArgs e)
        {
            Console.WriteLine("works");
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            
            countdownTimer.Text = seconds--.ToString();
            if(seconds < 0)
            {
                timer.Stop();
                gameOver newform = new gameOver();
                this.Hide();
                newform.ShowDialog();
                this.Show();
            }
            
        }

        private void orangeDot_Click(object sender, EventArgs e)
        {

        }

        private void yellowDot_Click(object sender, EventArgs e)
        {

        }
    }
}
