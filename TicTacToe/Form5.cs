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
    public partial class Form5 : Form
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
        public Form5()
        {
            CurrentGame = new Games
            {
                GameId = Program.CompletedGames.Count + 1
            };

            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {

            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button1.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click1++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            display();
            checkit();
            numCount++;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button2.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click2++;
                
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();
            numCount++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button3.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click3++;
                
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();
            numCount++;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button4.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click4++;
                
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();
            numCount++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button5.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click5++;
                
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();
            numCount++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button6.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click6++;
                
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();
            numCount++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button7.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click7++;
                
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();
            numCount++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button8.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click8++;
                
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();
            numCount++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                    player1moves++;
                    playermove1.Text = player1moves.ToString();
                }
                else
                {
                    button9.Text = "O";
                    player2moves++;
                    playermove2.Text = player2moves.ToString();
                }
                turn++;
                click9++;
                
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
            numCount++;
        }
        public void display()
        {
            if (turn % 2 != 0)
            {
                label6.Text = "Player 1";
            }
            else
            {
                label6.Text = "Player 2";
            }
        }
        public void checkit()
        {
            if (button1.Text != "" && button3.Text != "" && button2.Text != "")
            {
                if (button1.Text == button3.Text && button1.Text == button2.Text)
                {
                    if (button1.Text == "X")
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
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button6.Text && button4.Text == button5.Text)
                {
                    if (button4.Text == "X")
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
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button9.Text && button7.Text == button8.Text)
                {
                    if (button7.Text == "X")
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
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button7.Text && button1.Text == button4.Text)
                {
                    if (button1.Text == "X")
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
            
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button8.Text && button2.Text == button5.Text)
                {
                    if (button2.Text == "X")
                    {
                        
                        player1score++;
                        MessageBox.Show("Player 1 Wins " + player1score + " match(s) in "+ player1moves + " moves" + Environment.NewLine + "Player 2 wins " + player2score + " match(s)");
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
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button9.Text && button3.Text == button6.Text)
                {
                    if (button3.Text == "X")
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
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button9.Text && button1.Text == button5.Text)
                {
                    if (button1.Text == "X")
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
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    if (button3.Text == "X")
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
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("It's a Draw");
                ClearGame();
            }

        }
        public void GameOver() {
            CurrentGame.Player2Score = player2score;
            CurrentGame.Player1Score = player1score;
            Program.CompletedGames.Add(CurrentGame);
            CurrentGame = new Games {
                GameId = Program.CompletedGames.Count + 1
            };

        Form6 GameOver= new Form6();
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
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
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
            display();
            playermove1.Text = player1moves.ToString();
            playermove2.Text = player2moves.ToString();
            playerscore1.Text = player1score.ToString();
            playerscore2.Text = player2score.ToString();

        }

        public void score()
        {
            if (player1score == 2 && player2score == 1
                ||player1score == 3 && player2score == 0)

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
                ||player2score == 2 && player1score == 1)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
//https://www.c-sharpcorner.com/UploadFile/1e050f/creating-tic-tac-toe-step-by-step/
