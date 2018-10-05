using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Computer : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();
        int Computerscore = 0;
        int Playerscore = 0;
        int Computermoves = 0;
        int Playermoves = 0;
        private Games CurrentGame;
        public Computer()
        {
            CurrentGame = new Games
            {
                CompGameId = Program.CompCompletedGames.Count + 1
            };

            InitializeComponent();
            ClearGame();
        }
        
        private void loadbuttons()
        {
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.Transparent;
            buttons.Remove(button);
            Playermoves++;
            Playermove1.Text = Playermoves.ToString();
            Thread.Sleep(1000);
            WinorDraw();
            Check();                        

        }
        private void AIlogic()
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                buttons[index].ForeColor = Color.Black;
                buttons[index].BackColor = Color.Transparent;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);
                Computermoves++;
                Computermove1.Text = Computermoves.ToString();
                Check();
            }
        }
        private void WinorDraw()
        {
            

            if (btn1.Text == "" && btn2.Text == "O" && btn3.Text == "O"
    || btn1.Text == "" && btn4.Text == "O" && btn7.Text == "O"
    || btn1.Text == "" && btn5.Text == "O" && btn9.Text == "O")
            {
                if (buttons.Contains(btn1))
                {
                    btn1.Text = "O";
                    btn1.Enabled = false;
                    btn1.ForeColor = Color.Black;
                    btn1.BackColor = Color.Transparent;
                    buttons.Remove(btn1);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn1.Text == "O" && btn2.Text == "" && btn3.Text == "O"
                || btn2.Text == "" && btn5.Text == "O" && btn8.Text == "O")
            {
                if (buttons.Contains(btn2))
                {
                    btn2.Text = "O";
                    btn2.Enabled = false;
                    btn2.ForeColor = Color.Black;
                    btn2.BackColor = Color.Transparent;
                    buttons.Remove(btn2);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == ""
                || btn3.Text == "" && btn5.Text == "O" && btn7.Text == "O"
                || btn3.Text == "" && btn6.Text == "O" && btn9.Text == "O")
            {
                if (buttons.Contains(btn3))
                {
                    btn3.Text = "O";
                    btn3.Enabled = false;
                    btn3.ForeColor = Color.Black;
                    btn3.BackColor = Color.Transparent;
                    buttons.Remove(btn3);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "" && btn5.Text == "O" && btn6.Text == "O"
                || btn1.Text == "O" && btn4.Text == "" && btn7.Text == "O")
            {
                if (buttons.Contains(btn4))
                {
                    btn4.Text = "O";
                    btn4.Enabled = false;
                    btn4.ForeColor = Color.Black;
                    btn4.BackColor = Color.Transparent;
                    buttons.Remove(btn4);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "O" && btn5.Text == "" && btn6.Text == "O"
                 || btn1.Text == "O" && btn5.Text == "" && btn9.Text == "O"
                 || btn3.Text == "O" && btn5.Text == "" && btn7.Text == "O")
            {
                if (buttons.Contains(btn5))
                {
                    btn5.Text = "O";
                    btn5.Enabled = false;
                    btn5.ForeColor = Color.Black;
                    btn5.BackColor = Color.Transparent;
                    buttons.Remove(btn5);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == ""
                 || btn3.Text == "O" && btn6.Text == "" && btn9.Text == "O")
            {
                if (buttons.Contains(btn6))
                {
                    btn6.Text = "O";
                    btn6.Enabled = false;
                    btn6.ForeColor = Color.Black;
                    btn6.BackColor = Color.Transparent;
                    buttons.Remove(btn6);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "" && btn8.Text == "O" && btn9.Text == "O"
                || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == ""
                || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "")
            {
                if (buttons.Contains(btn7))
                {
                    btn7.Text = "O";
                    btn7.Enabled = false;
                    btn7.ForeColor = Color.Black;
                    btn7.BackColor = Color.Transparent;
                    buttons.Remove(btn7);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "O" && btn8.Text == "" && btn9.Text == "O"
                || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "")
            {
                if (buttons.Contains(btn8))
                {
                    btn8.Text = "O";
                    btn8.Enabled = false;
                    btn8.ForeColor = Color.Black;
                    btn8.BackColor = Color.Transparent;
                    buttons.Remove(btn8);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == ""
                || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == ""
                || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "")
            {
                if (buttons.Contains(btn9))
                {
                    btn9.Text = "O";
                    btn9.Enabled = false;
                    btn9.ForeColor = Color.Black;
                    btn9.BackColor = Color.Transparent;
                    buttons.Remove(btn9);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn1.Text == "" && btn2.Text == "X" && btn3.Text == "X"
                || btn1.Text == "" && btn4.Text == "X" && btn7.Text == "X"
                || btn1.Text == "" && btn5.Text == "X" && btn9.Text == "X")
            {
                if (buttons.Contains(btn1))
                {
                    btn1.Text = "O";
                    btn1.Enabled = false;
                    btn1.ForeColor = Color.Black;
                    btn1.BackColor = Color.Transparent;
                    buttons.Remove(btn1);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
             else if (btn1.Text == "X" && btn2.Text == "" && btn3.Text == "X"
                || btn2.Text == "" && btn5.Text == "X" && btn8.Text == "X")
            {
                if (buttons.Contains(btn2))
                {
                    btn2.Text = "O";
                    btn2.Enabled = false;
                    btn2.ForeColor = Color.Black;
                    btn2.BackColor = Color.Transparent;
                    buttons.Remove(btn2);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == ""
                || btn3.Text == "" && btn5.Text == "X" && btn7.Text == "X"
                || btn3.Text == "" && btn6.Text == "X" && btn9.Text == "X")
            {
                if (buttons.Contains(btn3))
                {
                    btn3.Text = "O";
                    btn3.Enabled = false;
                    btn3.ForeColor = Color.Black;
                    btn3.BackColor = Color.Transparent;
                    buttons.Remove(btn3);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "" && btn5.Text == "X" && btn6.Text == "X"
                || btn1.Text == "X" && btn4.Text == "" && btn7.Text == "X")
            {
                if (buttons.Contains(btn4))
                {
                    btn4.Text = "O";
                    btn4.Enabled = false;
                    btn4.ForeColor = Color.Black;
                    btn4.BackColor = Color.Transparent;
                    buttons.Remove(btn4);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "X" && btn5.Text == "" && btn6.Text == "X"
                 || btn1.Text == "X" && btn5.Text == "" && btn9.Text == "X"
                 || btn3.Text == "X" && btn5.Text == "" && btn7.Text == "X")
            {
                if (buttons.Contains(btn5))
                {
                    btn5.Text = "O";
                    btn5.Enabled = false;
                    btn5.ForeColor = Color.Black;
                    btn5.BackColor = Color.Transparent;
                    buttons.Remove(btn5);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == ""
                 || btn3.Text == "X" && btn6.Text == "" && btn9.Text == "X")
            {
                if (buttons.Contains(btn6))
                {
                    btn6.Text = "O";
                    btn6.Enabled = false;
                    btn6.ForeColor = Color.Black;
                    btn6.BackColor = Color.Transparent;
                    buttons.Remove(btn6);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "" && btn8.Text == "X" && btn9.Text == "X"
                || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == ""
                || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "")
            {
                if (buttons.Contains(btn7))
                {
                    btn7.Text = "O";
                    btn7.Enabled = false;
                    btn7.ForeColor = Color.Black;
                    btn7.BackColor = Color.Transparent;
                    buttons.Remove(btn7);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "X" && btn8.Text == "" && btn9.Text == "X"
                || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "")
            {
                if (buttons.Contains(btn8))
                {
                    btn8.Text = "O";
                    btn8.Enabled = false;
                    btn8.ForeColor = Color.Black;
                    btn8.BackColor = Color.Transparent;
                    buttons.Remove(btn8);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == ""
                || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == ""
                || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "")
            {
                if (buttons.Contains(btn9))
                {
                    btn9.Text = "O";
                    btn9.Enabled = false;
                    btn9.ForeColor = Color.Black;
                    btn9.BackColor = Color.Transparent;
                    buttons.Remove(btn9);
                    Computermoves++;
                    Computermove1.Text = Computermoves.ToString();
                }
            }

            else
            {
                AIlogic();

            }

        }
        private void Check()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"
                || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X"
                || btn7.Text == "X" && btn9.Text == "X" && btn8.Text == "X"
                || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"
                || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"
                || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"
                || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"
                || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                Playerscore++;


                label7.Text = Playerscore.ToString();
                MessageBox.Show("Player Wins " + Playerscore + " match(s) in " + Playermoves + " moves" + Environment.NewLine + "Computer wins " + Computerscore + " match(s)");
                Playermoves = 0;

                ClearGame();
                score();
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O"
                || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O"
                || btn7.Text == "O" && btn9.Text == "O" && btn8.Text == "O"
                || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O"
                || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O"
                || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O"
                || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O"                || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                Computerscore++;
                
                label8.Text = Computerscore.ToString();
                MessageBox.Show("Computer Wins " + Computerscore + " match(s) in " + Computermoves + " moves" + Environment.NewLine + "Player wins " + Playerscore + " match(s)");
                Computermoves = 0;
                ClearGame();
                score();
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" &&
                    btn4.Text != "" && btn5.Text != "" && btn6.Text != "" &&
                    btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
                {
                MessageBox.Show("It's a Draw");
                ClearGame();
            }
        }
        public void score()
        {
            if (Computerscore == 2 && Playerscore == 1
                || Computerscore == 3 && Playerscore == 0)

            {
                MessageBox.Show("Computer Wins Overall!" + Environment.NewLine + "Computer Score: " + Computerscore + " match(s)"
                    + Environment.NewLine + "Player Score: " + Playerscore + " match(s)");
                GameOver();
            }
            else if (Playerscore == 3 && Computerscore == 0
                || Playerscore == 2 && Computerscore == 1)
            {
                MessageBox.Show("Player Wins Overall!" + Environment.NewLine + "Player Score: " + Playerscore + " match(s)"
                    + Environment.NewLine + "Computer Score: " + Computerscore + " match(s)");
                GameOver();
            }
            else
            {
                ClearGame();
            }
        }

        public void ClearGame()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            Computermoves = 0;
            Playermoves = 0;
            Playermove1.Text = Playermoves.ToString();
            Computermove1.Text = Computermoves.ToString();
            loadbuttons();
            AIlogic();

        }
        public void GameOver()
        {
            CurrentGame.PlayerScore = Playerscore;
            CurrentGame.ComputerScore = Computerscore;
            CurrentGame.Mode = "Player vs Computer";
            Program.CompCompletedGames.Add(CurrentGame);
            CurrentGame = new Games
            {
                CompGameId = Program.CompCompletedGames.Count + 1
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
        private void btn10_Click(object sender, EventArgs e)
        {
            Mode Mode = new Mode();
            this.Hide();
            Mode.ShowDialog();
            Mode.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
}
//https://www.mooict.com/wp-content/uploads/2017/10/c-sharp-create-a-tic-tac-toe-game-play-against-ai-opponent20.pdf
