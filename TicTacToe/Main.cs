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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Mode Mode = new Mode();
            this.Hide();
            Mode.ShowDialog();
            Mode.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            History History = new History();
            this.Hide();
            History.ShowDialog();
            History.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            HowToPlay Howto = new HowToPlay();
            this.Hide();
            Howto.ShowDialog();
            Howto.FormClosed += new FormClosedEventHandler(cl_FormClosed);
        }
    }
}
