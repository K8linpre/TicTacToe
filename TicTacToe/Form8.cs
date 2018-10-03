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
        int Computerscore = 0;
        int Playerscore = 0;
        int Computermoves = 0;
        int Playermoves = 0;
        public Form8()
        {
            InitializeComponent();
            ClearGame();
            AImoves.Start();
        }
        
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                buttons[index].ForeColor = Color.Black;
                buttons[index].BackColor = Color.Transparent;
                currentPlayer = Player.O;
                label6.Text = "Player";
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);
                Computermoves++;
                Computermove1.Text = Computermoves.ToString();
                Check();
                
                AImoves.Stop();
            }
        }
        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            label6.Text = "Computer";
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.Transparent;
            buttons.Remove(button);
            Playermoves++;
            Playermove1.Text = Playermoves.ToString();
     //     WinorDraw();
            Check();
            
            AImoves.Start();

        }
 /*     private void WinorDraw()
        {
            if (button1.Text == "" && button2.Text == "X" && button3.Text == "X"
                || button1.Text == "" && button4.Text == "X" && button7.Text == "X"
                || button1.Text == "" && button5.Text == "X" && button9.Text == "X")
            {
                buttons = new List<Button> { button2 };
            }
            if (button1.Text == "X" && button2.Text == "" && button3.Text == "X"
                || button2.Text == "" && button5.Text == "X" && button9.Text == "X")
            {
                buttons = new List<Button> { button2 };
            }
        }     */

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
                Playerscore++;


                label7.Text = Playerscore.ToString();
                MessageBox.Show("Player Wins " + Playerscore + " match(s) in " + Playermoves + " moves" + Environment.NewLine + "Computer wins " + Computerscore + " match(s)");
                Playermoves = 0;

                ClearGame();
                
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
                Computerscore++;
                
                label8.Text = Computerscore.ToString();
                MessageBox.Show("Computer Wins " + Computerscore + " match(s) in " + Computermoves + " moves" + Environment.NewLine + "Player wins " + Playerscore + " match(s)");

                ClearGame();
                
                score();
            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "")
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
            Computermoves = 0;
            Playermoves = 0;
            Playermove1.Text = Playermoves.ToString();
            Computermove1.Text = Computermoves.ToString();
            loadbuttons();

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

    }
}
//https://www.mooict.com/wp-content/uploads/2017/10/c-sharp-create-a-tic-tac-toe-game-play-against-ai-opponent20.pdf
