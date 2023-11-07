using Mastermind_v2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_v2
{
    public partial class Military : Form
    {
        public int currentColumn = 0;
        public int currentRow = 0;
        public string[] guessArray = new string[4];
        public string[] answer = new string[4];
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        int val = 30;
        public Military()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Military_Load(object sender, EventArgs e)
        {
            string[] colourArray = { "red", "orange", "yellow", "green", "blue", "purple" };
            Random rondo = new Random();

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
            if (currentColumn != 4)
            {
                var cell = new PictureBox();

                cell.Dock = DockStyle.Fill;
                cell.Padding = new Padding();
                cell.Margin = new Padding(9, 4, 9, 12);

                switch (colourButton)
                {
                    case "red":
                        cell.BackgroundImage = Resources.red;
                        guessArray[currentColumn] = colourButton;
                        break;

                    case "orange":
                        cell.BackgroundImage = Resources.orange;
                        guessArray[currentColumn] = colourButton;
                        break;

                    case "yellow":
                        cell.BackgroundImage = Resources.yellow;
                        guessArray[currentColumn] = colourButton;
                        break;

                    case "green":
                        cell.BackgroundImage = Resources.green;
                        guessArray[currentColumn] = colourButton;
                        break;

                    case "blue":
                        cell.BackgroundImage = Resources.blue;
                        guessArray[currentColumn] = colourButton;
                        break;

                    case "purple":
                        cell.BackgroundImage = Resources.purple;
                        guessArray[currentColumn] = colourButton;
                        break;
                }

                cell.BackgroundImageLayout = ImageLayout.Stretch;

                boardGrid.Controls.Add(cell, currentColumn, currentRow);

                currentColumn++;

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
           if (currentColumn == 4)
            {
                if (answer.SequenceEqual(guessArray))
                {
                    timer.Stop();
                    winGame();
                    MessageBox.Show("win");
                } else
                {
                    checkGuess();
                    MessageBox.Show("Guess Incorrect, please try again.");
                    currentColumn = 0;
                    currentRow++;
                    if (currentRow == 8)
                    {
                        gameOver newform = new gameOver();
                        this.Close();
                        newform.ShowDialog();
                    }
                }

            }
        }

        private void checkGuess()
        {
            Tuple<int, int> EvaluateGuess(string[] answer, string[] guessArray)
            {
                int exactMatches = 0;
                int colorMatches = 0;

                Dictionary<string, int> answerCounts = new Dictionary<string, int>();
                Dictionary<string, int> guessArrayCounts = new Dictionary<string, int>();

                // First, count the exact matches
                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] == guessArray[i])
                    {
                        exactMatches++;
                    }
                }

                // Then, count the color matches (ignoring exact matches)
                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] != guessArray[i])
                    {
                        answerCounts[answer[i]] = answerCounts.GetValueOrDefault(answer[i], 0) + 1;
                       guessArrayCounts[guessArray[i]] = guessArrayCounts.GetValueOrDefault(guessArray[i], 0) + 1;
                    }
                }

                foreach (var colour in guessArrayCounts.Keys)
                {
                    if (answerCounts.ContainsKey(colour))
                    {
                        colorMatches += Math.Min(guessArrayCounts[colour], answerCounts[colour]);
                    }
                }

                return Tuple.Create(exactMatches, colorMatches);
            }
        }
        
        private void winGame()
        {
            for (int i = 0; i < 4; i++)
            {
                var cell = new PictureBox();

                cell.Dock = DockStyle.Fill;
                cell.Padding = new Padding();
                cell.Margin = new Padding(4, 4, 4, 5);

                switch (answer[i])
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

                answerGrid.Controls.Add(cell, i, 0);

            }
        }
    }
}
