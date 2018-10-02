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
    public partial class Form8 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();
        int PlayerWins = 0;
        int ComputerWins = 0;
        /*    int Computerscore;
            int Playerscore;
            int Computermoves = 0;
            int Playermoves = 0;
            int turn = 1;
            int numCount = 0;*/
        public Form8()
        {
            InitializeComponent();
            resetGame();
        }
        
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            buttons.Remove(button);
            Check();
            AImoves.Start();
        }
        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;

                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);
                Check();
                AImoves.Stop();
            }
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                }
            }
            loadbuttons();
        }
        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                AImoves.Stop();
                MessageBox.Show("Player Wins");
                PlayerWins++;
                label7.Text = PlayerWins.ToString();
                ClearGame();
                resetGame();
                score();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                AImoves.Stop();
                MessageBox.Show("Computer Wins");
                ComputerWins++;
                label8.Text = ComputerWins.ToString();
                ClearGame();
                resetGame();
                score();
            }
        }
        public void ClearGame()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            /*  Computermoves = 0;
                Playermoves = 0;
                turn = 1;
                Computerscore1.Text = Computerscore.ToString();
                Playerscore1.Text = Playerscore.ToString();*/

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
        public void score()
        {
            if (PlayerWins == 3)

            {
                MessageBox.Show("Player Wins Overall!" + Environment.NewLine + "Player Score: " + PlayerWins + " match(s)"
                    + Environment.NewLine + "Computer Score: " + ComputerWins + " match(s)");
                GameOver();
            }
            else if (ComputerWins == 3)
            {
                MessageBox.Show("Computer Wins Overall!" + Environment.NewLine + "Player Score: " + PlayerWins + " match(s)"
                    + Environment.NewLine + "Computer Score: " + ComputerWins + " match(s)");
                GameOver();
            }
            else
            {
                ClearGame();
            }
        }
    }
}
//https://www.mooict.com/wp-content/uploads/2017/10/c-sharp-create-a-tic-tac-toe-game-play-against-ai-opponent20.pdf
