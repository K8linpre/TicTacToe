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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var game in Program.CompletedGames)
            {
                TxtBx2.Text += $"\r\nGame {game.GameId}\r\nPlayer 1 Score: {game.Player1Score}\r\nPlayer 2 Score: {game.Player2Score}";
            }
            foreach (var game in Program.CompCompletedGames)
            {
                txtBx1.Text += $"\r\nGame {game.CompGameId}\r\nPlayer Score: {game.PlayerScore}\r\nComputer Score: {game.ComputerScore}";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            this.Hide();
            Main.ShowDialog();
            Main.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
}
