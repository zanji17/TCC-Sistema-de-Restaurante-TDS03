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
        public FormHomeGerente()
        {
            InitializeComponent();
        }

        private void pbCadAtendente_Click(object sender, EventArgs e)
        {
            FormAtendente atendente = new FormAtendente();
            atendente.Show();
        }

        private void pbIngredientes_Click(object sender, EventArgs e)
        {
            FormIngredientes ingredientes = new FormIngredientes();
            ingredientes.Show();
        }

        private void pbPratosProdutos_Click(object sender, EventArgs e)
        {
            FormPratosProdutos PP = new FormPratosProdutos();
            PP.Show();
        }

        private void pbAcesso_Click(object sender, EventArgs e)
        {
            FormAcesso acesso = new FormAcesso();
            acesso.Show();
        }

        private void pbAtendimento_Click(object sender, EventArgs e)
        {
            FormAtendimento atendimento = new FormAtendimento();
            atendimento.Show();
        }

        private void pbPedidos_Click(object sender, EventArgs e)
        {
            FormRelatorioPedidos pedidos = new FormRelatorioPedidos();
            pedidos.Show();
        }

        private void pbAtendente_Click(object sender, EventArgs e)
        {
            FormHomeAtendente ha = new FormHomeAtendente();
            ha.Show();
        }

        private void pbCozinha_Click(object sender, EventArgs e)
        {
            FormHomeCozinha hcozinha = new FormHomeCozinha();
            hcozinha.Show();
        }

        private void pbCaixa_Click(object sender, EventArgs e)
        {
            FormHomeCaixa hcaixa = new FormHomeCaixa();
            hcaixa.Show();
        }
    }
}
