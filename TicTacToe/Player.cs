using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Player : Form
    {
        int click1 = 0;
        int click2 = 0;
        int click3 = 0;
        int click4 = 0;
        int click5 = 0;
        int click6 = 0;
        int click7 = 0;
        int click8 = 0;
        int click9 = 0;
        int player1score;
        int player2score;
        int player1moves = 0;
        int player2moves = 0;
        int turn = 1;
        int numCount = 0;
        private Games CurrentGame;
        public Player()
        {
            CurrentGame = new Games
            {
                GameId = Program.CompletedGames.Count + 1
            };

            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn1.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn1.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click1++;

            }
            else
            {
                btn2.Text = btn2.Text;
            }
            checkit();
            numCount++;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn2.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn2.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click2++;

            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn3.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn3.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click3++;
            }
            else
            {
                btn3.Text = btn3.Text;
            }
            checkit();
            numCount++;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn4.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn4.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click4++;

            }
            else
            {
                btn4.Text = btn4.Text;
            }
            checkit();
            numCount++;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn5.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn5.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click5++;

            }
            else
            {
                btn5.Text = btn5.Text;
            }
            checkit();
            numCount++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn6.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn6.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click6++;

            }
            else
            {
                btn6.Text = btn6.Text;
            }
            checkit();
            numCount++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn7.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn7.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click7++;

            }
            else
            {
                btn7.Text = btn7.Text;
            }
            checkit();
            numCount++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn8.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn8.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click8++;

            }
            else
            {
                btn8.Text = btn8.Text;
            }
            checkit();
            numCount++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn9.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    btn9.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click9++;

            }
            else
            {
                btn9.Text = btn9.Text;
            }
            checkit();
            numCount++;
        }
        public void checkit()
        {
            if (btn1.Text != "" && btn3.Text != "" && btn2.Text != "")
            {
                if (btn1.Text == btn3.Text && btn1.Text == btn2.Text)
                {
                    if (btn1.Text == "X")
                    {
                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }

            }
            if (btn4.Text != "" && btn5.Text != "" && btn6.Text != "")
            {
                if (btn4.Text == btn6.Text && btn4.Text == btn5.Text)
                {
                    if (btn4.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }

            }
            if (btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                if (btn7.Text == btn9.Text && btn7.Text == btn8.Text)
                {
                    if (btn7.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }
            }
            if (btn1.Text != "" && btn4.Text != "" && btn7.Text != "")
            {
                if (btn1.Text == btn7.Text && btn1.Text == btn4.Text)
                {
                    if (btn1.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }

            }

            if (btn2.Text != "" && btn5.Text != "" && btn8.Text != "")
            {
                if (btn2.Text == btn8.Text && btn2.Text == btn5.Text)
                {
                    if (btn2.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }
            }
            if (btn3.Text != "" && btn6.Text != "" && btn9.Text != "")
            {
                if (btn3.Text == btn9.Text && btn3.Text == btn6.Text)
                {
                    if (btn3.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score++ + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }

            }
            if (btn1.Text != "" && btn5.Text != "" && btn9.Text != "")
            {
                if (btn1.Text == btn9.Text && btn1.Text == btn5.Text)
                {
                    if (btn1.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }
            }
            if (btn3.Text != "" && btn5.Text != "" && btn7.Text != "")
            {
                if (btn3.Text == btn5.Text && btn3.Text == btn7.Text)
                {
                    if (btn3.Text == "X")
                    {

                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in " + player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
                        score();
                    }
                    else
                    {

                        player2score++;
                        MessageBox.Show("Player 2 Wins " + player2score + " match(s) in " + player2moves + " moves" + Environment.NewLine + "Player 1 wins " + player1score + " match(s)");
                        score();
                    }
                }
            }
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" &&
                    btn4.Text != "" && btn5.Text != "" && btn6.Text != "" &&
                    btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("It's a Draw");
                ClearGame();
            }

        }
        public void GameOver()
        {
            CurrentGame.Player2Score = player2score;
            CurrentGame.Player1Score = player1score;
            CurrentGame.Mode = "Player vs Player";
            Program.CompletedGames.Add(CurrentGame);
            CurrentGame = new Games
            {
                GameId = Program.CompletedGames.Count + 1
            };

            Finish GameOver = new Finish();
            this.Hide();
            GameOver.ShowDialog();
            GameOver.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ClearGame()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;
            player1moves = 0;
            player2moves = 0;
            turn = 1;
            playermove1.Text = player1moves.ToString();
            playermove2.Text = player2moves.ToString();
            playerscore1.Text = player1score.ToString();
            playerscore2.Text = player2score.ToString();

        }

        public void score()
        {
            if (player1score == 2 && player2score == 1
                || player1score == 3 && player2score == 0)

            {
                MessageBox.Show("Player 1 Wins Overall!" + Environment.NewLine + "Player 1 Score: " + player1score + " match(s)"
                    + Environment.NewLine + "Player 2 Score: " + player2score + " match(s)");

                GameOver();
                player1score = 0;
                player2score = 0;

                playerscore1.Text = player1score.ToString();
                playerscore2.Text = player2score.ToString();

            }
            else if (player2score == 3 && player1score == 0
                || player2score == 2 && player1score == 1)
            {
                MessageBox.Show("Player 2 Wins Overall!" + Environment.NewLine + "Player 1 Score: " + player1score + " match(s)"
                    + Environment.NewLine + "Player 2 Score: " + player2score + " match(s)");

                GameOver();
                player1score = 0;
                player2score = 0;
                playerscore1.Text = player1score.ToString();
                playerscore2.Text = player2score.ToString();

            }
            else
            {
                ClearGame();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Mode Mode = new Mode();
            this.Hide();
            Mode.ShowDialog();
            Mode.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
}
//https://www.c-sharpcorner.com/UploadFile/1e050f/creating-tic-tac-toe-step-by-step/
