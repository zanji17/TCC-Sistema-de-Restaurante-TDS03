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
        public FormHomeGerente(int id)
        {
            IdGerente = id;
            InitializeComponent();
        }

        private void pbAtendente_Click(object sender, EventArgs e)
        {
            FormHomeAtendente ha = new FormHomeAtendente(IdGerente);
            ha.Show();
        }

        private void pbCozinha_Click(object sender, EventArgs e)
        {
            FormHomeCozinha hcozinha = new FormHomeCozinha(IdGerente);
            hcozinha.Show();
        }

        private void pbCaixa_Click(object sender, EventArgs e)
        {
            FormHomeCaixa hcaixa = new FormHomeCaixa(IdGerente);
            hcaixa.Show();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtendente atendente = new FormAtendente();
            atendente.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngrediente ingredientes = new FormIngrediente();
            ingredientes.Show();
        }

        private void pratosEProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPratosProdutos PP = new FormPratosProdutos();
            PP.Show();
        }

        private void acessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcesso acesso = new FormAcesso();
            acesso.Show();
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtendimento atendimento = new FormAtendimento();
            atendimento.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioPedidos pedidos = new FormRelatorioPedidos();
            pedidos.Show();
        }

        private void modeloDeAdicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModeloAdicional ma = new FormModeloAdicional();
            ma.Show();
        }
    }
}
