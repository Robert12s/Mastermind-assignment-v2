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

        int val = 400;
        public Military() 
        {
            InitializeComponent();
            timer.Start(); // starts the timer
        }

        private void Military_Load(object sender, EventArgs e)
        {
            string[] colourArray = { "red", "orange", "yellow", "green", "blue", "purple" };
            Random rondo = new Random();

            for (int i = 0; i < 4; i++)
            {
                int num = rondo.Next(0, 6);
                answer[i] = colourArray[num]; // creates a random array of 4 colours
                 
            }
            DisplayArray(answer);

        }

        private void timer_Tick(object sender, EventArgs e) // this function allows the timer to work
        {
            int timeLeft = val--;
            countdownTimer.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                RevealAnswer();
                gameOver newform = new gameOver();
                this.Close();
                newform.ShowDialog();
            }

        }

        private void fill_board(string colourButton) // Places the users guesses on the board
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
                if (answer.SequenceEqual(guessArray)) // checks if the users guess is exactly correct
                {
                    timer.Stop();
                    var returnTuple = checkGuess();
                    var exactMatches = returnTuple.Item1;
                    var colourMatches = returnTuple.Item2;
                    plotClueDots(exactMatches, colourMatches);
                    RevealAnswer();
                    gameWin newform = new gameWin();
                    newform.ShowDialog();
                } else
                {

                    var returnTuple = checkGuess();
                    var exactMatches = returnTuple.Item1;
                    var colourMatches = returnTuple.Item2;
                    plotClueDots(exactMatches, colourMatches);
                    currentColumn = 0;
                    currentRow++;
                    if (currentRow == 8)
                    {
                        RevealAnswer();
                        gameOver newform = new gameOver(); // mission failed form
                        this.Close();
                        newform.ShowDialog();
                    }
                }

            }
            
        }

        private Tuple<int, int> checkGuess()
        {
            int exactMatches = 0;
            int colourMatches = 0;
            // Count the exact matches and find the remaining elements
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == guessArray[i])
                {
                    exactMatches++;
                }

            }
            
            // Count the color matches (ignoring the exact matches)
            for (int i = 0; i < guessArray.Length; i++)
            {
                for (int j = 0; j < answer.Length; j++)
                {
                    if (answer[j] == guessArray[i] && answer[i] != guessArray[i])
                    {
                        colourMatches++;
                        break;
                    }
                }
            }

            Console.WriteLine("The exact matches are " + exactMatches);
            Console.WriteLine("The colour matches are " + colourMatches);

            return Tuple.Create(exactMatches, colourMatches) as Tuple<int, int>;

        }

        private void plotClueDots(int exactMatches, int colourMatches) // Plots the black and pink pegs depending on the users guess
        {
            int currentClueColumn = 0;
            int currentClueRow = 0;

            for (int i = 0; i < exactMatches; i++)
            {
                var cell = new PictureBox();

                cell.Dock = DockStyle.Fill;
                cell.Padding = new Padding();
                cell.Margin = new Padding(4, 4, 4, 4);
                cell.BackgroundImageLayout = ImageLayout.Stretch;
                cell.BackgroundImage = Resources.black;

                switch (currentRow)
                {
                    case 0:
                        clueGrid1.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 1:
                        clueGrid2.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 2:
                        clueGrid3.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 3:
                        clueGrid4.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 4:
                        clueGrid5.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 5:
                        clueGrid6.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 6:
                        clueGrid7.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 7:
                        clueGrid8.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                }

                if (currentClueColumn == 1)
                {
                    currentClueRow++;
                    currentClueColumn = 0;
                }
                else
                {
                    currentClueColumn++;
                }

            }

            for (int i = 0; i < colourMatches; i++)
            {
                var cell = new PictureBox();

                cell.Dock = DockStyle.Fill;
                cell.Padding = new Padding();
                cell.Margin = new Padding(4, 4, 4, 4);
                cell.BackgroundImageLayout = ImageLayout.Stretch;
                cell.BackgroundImage = Resources.pink;
                switch (currentRow)
                {
                    case 0:
                        clueGrid1.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 1:
                        clueGrid2.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 2:
                        clueGrid3.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 3:
                        clueGrid4.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 4:
                        clueGrid5.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 5:
                        clueGrid6.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 6:
                        clueGrid7.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                    case 7:
                        clueGrid8.Controls.Add(cell, currentClueColumn, currentClueRow);
                        break;
                }

                if (currentClueColumn == 1)
                {
                    currentClueRow++;
                    currentClueColumn = 0;
                }
                else
                {
                    currentClueColumn++;
                }
            }   
        }

        private void RevealAnswer() // reveals answer in the top left hand corner of the board
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
