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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if((txtLogin.Text != "" && txtLogin.Text != null) && (txtSenha.Text != "" && txtSenha != null))
            {
                Login log = new Login();
                log.Logar(txtLogin.Text, txtSenha.Text);
                if(log.cargo == "Gerente")
                {
                    this.Hide();
                    FormHomeGerente hg = new FormHomeGerente(log.Id);
                    hg.Show();
                }
                else if (log.cargo == "Atendente")
                {
                    this.Hide();
                    FormHomeAtendente ha = new FormHomeAtendente(log.Id);
                    ha.Show();
                }
                else if (log.cargo == "Cozinha")
                {
                    this.Hide();
                    FormHomeCozinha hcozinha = new FormHomeCozinha(log.Id);
                    hcozinha.Show();
                }
                if (log.cargo == "Caixa")
                {
                    this.Hide();
                    FormHomeCaixa hcaixa = new FormHomeCaixa(log.Id);
                    hcaixa.Show();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
