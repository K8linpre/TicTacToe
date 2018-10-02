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
    public partial class Form7 : Form
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
        int turn = 1;
        string Computer = "X";
        string Player = "O";
        public Form7()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
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
        }
        public void display()
        {
            if (turn % 2 != 0)
            {
                label6.Text = "Computer";
            }
            else
            {
                label6.Text = "Player";
            }     }
        public void checkit()
        {
            if (button1.Text != "" && button3.Text != "" && button2.Text != "")
            {
                if (button1.Text == button3.Text && button1.Text == button2.Text)
                {
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Computer Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }

            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button6.Text && button4.Text == button5.Text)
                {
                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }

            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button9.Text && button7.Text == button8.Text)
                {
                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button7.Text && button1.Text == button4.Text)
                {
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }

            }

            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button8.Text && button2.Text == button5.Text)
                {
                    if (button2.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button9.Text && button3.Text == button6.Text)
                {
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    GameOver();
                }

            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button9.Text && button1.Text == button5.Text)
                {
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1score++;
                        Computer = Computer.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2score++;
                        Player = Player.ToString();
                    }
                    ClearGame();
                }
                else
                {
                    MessageBox.Show("Draw!");
                    GameOver();
                }

            }
        }
        public void GameOver()
        {
            Form6 GameOver = new Form6();
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
            turn = 1;
            int label7;
            label7 = player1score;
        }

        private void playerClick(object sender, EventArgs e)
        {

        }
        private void AImove(object sender, EventArgs e)
        {

        }

    }

}
