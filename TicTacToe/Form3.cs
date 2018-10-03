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

        private void label2_Click(object sender, EventArgs e)
        {
            int[] array = new int[2];

            for (int num = 1; num < array.Length; num++)
            {

                label2.Text = "Game One" + Environment.NewLine + "Player 1 Score : " + Form5.A1 + Environment.NewLine +"Player 2 Score : " + Form5.B1 + Environment.NewLine +
                   "Game Two" + Environment.NewLine +"Player 1 Score : " + Form5.A2 + Environment.NewLine +"Player 2 Score : " + Form5.B2;
            }
        }
    }
}
