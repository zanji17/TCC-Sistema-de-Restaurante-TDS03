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
    public partial class sugestao : Form
    {
        public sugestao(string msg)
        {
            InitializeComponent();

            mensagem = msg ;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            resultado = "N";
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            resultado = "S";
            this.Close();
        }

        public string mensagem { get; set; }

        public string resultado { get; set; }

        private void sugestao_Load(object sender, EventArgs e)
        {
            lblSusgenstao.Text = mensagem;
        }

        private void sugestao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(resultado == "S")
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
