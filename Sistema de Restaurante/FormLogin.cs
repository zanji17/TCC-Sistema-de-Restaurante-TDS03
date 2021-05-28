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
                    using (FormHomeGerente hg = new FormHomeGerente(log.Id, log.cargo) { })
                    {
                        if(hg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                }
                else if (log.cargo == "Atendente")
                {
                    this.Hide();
                    using (FormHomeAtendente ha = new FormHomeAtendente(log.Id, log.cargo) { })
                    {
                        if (ha.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                }
                else if (log.cargo == "Cozinha")
                {
                    this.Hide();
                    using (FormHomeCozinha hcozinha = new FormHomeCozinha(log.Id) { })
                    {
                        if (hcozinha.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                }
                if (log.cargo == "Caixa")
                {
                    this.Hide();
                    using (FormHomeCaixa hcaixa = new FormHomeCaixa(log.Id) { })
                    {
                        if(hcaixa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
