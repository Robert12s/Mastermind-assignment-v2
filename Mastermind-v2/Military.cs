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

        public Military()
        {
            InitializeComponent();
        }

        private void Military_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (8 * 60 * 1000); // 8 mins
            MyTimer.Tick += new EventHandler(timer_Tick);
            MyTimer.Start();

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
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
            gameOver newform = new gameOver();
            this.Close();
            newform.ShowDialog();
            
        }
    }
}
