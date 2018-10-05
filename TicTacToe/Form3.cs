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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();
            Main.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var game in Program.CompletedGames)
            {
                textBox2.Text += $"\r\nGame {game.GameId}\r\nPlayer 1 Score: {game.Player1Score}\r\nPlayer 2 Score: {game.Player2Score}";
            }
            foreach (var game in Program.CompCompletedGames)
            {
                textBox1.Text += $"\r\nGame {game.GameId}\r\nPlayer Score: {game.PlayerScore}\r\nComputer Score: {game.ComputerScore}";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
