using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class erro : Form
    {
        public erro(string msg)
        {
            InitializeComponent();
            mensagem = msg;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSusgenstao.Text = mensagem;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            ProgressBar1.Increment(3);
            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }


        }

        private void erro_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.DialogResult = DialogResult.OK;
        }

        public string mensagem { get; set; }
    }
}
