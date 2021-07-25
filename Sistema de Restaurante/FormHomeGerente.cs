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
    public partial class FormHomeGerente : Form
    {
        public int IdGerente { get; set; }

        public string cargo { get; set; }

        public FormHomeGerente(int id, string tipo)
        {
            IdGerente = id;
            cargo = tipo;
            InitializeComponent();
        }
        //-------------------------------------------------------

        private void esconder_SubMenu()
        {
            painel_formularios.Visible = false;
            painel_cadastros.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFPedidos_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();

            FormRelatorioPedidos rp = new FormRelatorioPedidos();
            rp.Show();
        }

        private void BtnFAtendimento_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormAtendimento atendimento = new FormAtendimento();
            atendimento.Show();
        }

        private void FormHomeGerente_Load(object sender, EventArgs e)
        {
            esconder_SubMenu();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            painel_cadastros.Visible = false;

            if (painel_formularios.Visible == false)
            {
                painel_formularios.Visible = true;
            }
            else
            {
                painel_formularios.Visible = false;
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            painel_formularios.Visible = false;

            if(painel_cadastros.Visible == false)
            {
                painel_cadastros.Visible = true;
            }
            else
            {
                painel_cadastros.Visible = false;
            }
        }

        private void FormHomeGerente_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormAcesso acesso = new FormAcesso();
            acesso.Show();
        }

        private void btnAtendentes_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormAtendente atendente = new FormAtendente();
            atendente.Show();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormIngrediente ingredientes = new FormIngrediente();
            ingredientes.Show();
        }

        private void btnModeloAdicional_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormModeloAdicional ma = new FormModeloAdicional();
            ma.Show();
        }

        private void btnPratosProdutos_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormPratosProdutos PP = new FormPratosProdutos();
            PP.Show();
        }

        private void BtnCozinha_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormHomeCozinha hcozinha = new FormHomeCozinha(cargo);
            hcozinha.Show();
        }

        private void BtnAtendente_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormHomeAtendente atendente = new FormHomeAtendente(IdGerente, cargo);
            atendente.Show();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            esconder_SubMenu();
            FormHomeCaixa caixa = new FormHomeCaixa(cargo);
            caixa.Show();
        }

        private void PbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHomeGerente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
