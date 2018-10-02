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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 Howto = new Form2();
            this.Hide();
            Howto.ShowDialog();
            Howto.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 History = new Form3();
            this.Hide();
            History.ShowDialog();
            History.FormClosed += new FormClosedEventHandler(cl_FormClosed);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 Mode = new Form4();
            this.Hide();
            Mode.ShowDialog();
            Mode.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
