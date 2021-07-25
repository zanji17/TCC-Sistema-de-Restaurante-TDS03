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
    public partial class FormRelatorioPedidos : Form
    {
        public FormRelatorioPedidos()
        {
            InitializeComponent();
        }

        private void FormRelatorioPedidos_Load(object sender, EventArgs e)
        {
            atualizarDGV();
        }

        private void dtpInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpInicial.CustomFormat = " ";
            }
        }

        private void dtpFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFinal.CustomFormat = " ";
            }
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpInicial.CustomFormat = "dd/MM/yyyy";
            atualizarDGV();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.CustomFormat = "dd/MM/yyyy";
            atualizarDGV();
        }

        public void atualizarDGV()
        {
            string datainicial = "";
            string datafinal = "";
            if (dtpInicial.CustomFormat != " " && dtpFinal.CustomFormat == " ")
            {
                datainicial = dtpInicial.Value.ToString("yyyy-MM-dd");
                DateTime hoje = DateTime.Now;
                datafinal = hoje.ToString("yyyy-MM-dd");
            }
            else if (dtpInicial.CustomFormat == " " && dtpFinal.CustomFormat != " ")
            {
                datafinal = dtpFinal.Value.ToString("yyyy-MM-dd");
                DateTime hoje = DateTime.MinValue;
                datainicial = hoje.ToString("yyyy-MM-dd");
            }
            else if (dtpInicial.CustomFormat != " " && dtpFinal.CustomFormat != " ")
            {
                datainicial = dtpInicial.Value.ToString("yyyy-MM-dd");
                datafinal = dtpFinal.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                DateTime hoje = DateTime.Now;
                datainicial = hoje.ToString("yyyy-MM-dd");
                datafinal = hoje.ToString("yyyy-MM-dd");
            }

            Pedidos pedidos = new Pedidos();
            List<Pedidos> pedido = pedidos.PedidosRelatorio(datainicial, datafinal);
            dgvPedidos.DataSource = pedido;
            dgvPedidos.Columns.Remove("endereco");
            dgvPedidos.Columns.Remove("bairro");
            dgvPedidos.Columns.Remove("complemento");
            dgvPedidos.Columns.Remove("telefone");
            dgvPedidos.Columns.Remove("CPF");
            dgvPedidos.Columns.Remove("NumeroPedidos");
            dgvPedidos.Columns.Remove("NumeroPratos");
            dgvPedidos.Columns[7].HeaderText = "Situação";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPedidos.Rows[e.RowIndex];
                FormDetalhesPedido detalhespedido = new FormDetalhesPedido((int)row.Cells[0].Value);
                detalhespedido.Show();
            }
        }
    }
}
