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
    public partial class FormAtendimento : Form
    {
        public FormAtendimento()
        {
            InitializeComponent();
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            List<Pedidos> lista = pedido.ListarAtendimento();
            dgvAtendentes.DataSource = lista;
            dgvAtendentes.Columns.Remove("IdPedido");
            dgvAtendentes.Columns.Remove("Cliente");
            dgvAtendentes.Columns.Remove("Mesa");
            dgvAtendentes.Columns.Remove("Pessoas");
            dgvAtendentes.Columns.Remove("Data");
            dgvAtendentes.Columns.Remove("Status");
        }

        private void dgvAtendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAtendentes.Rows[e.RowIndex];
            Pedidos pedido = new Pedidos();
            List<Pedidos> lista = pedido.ListarPedidos((int)row.Cells[0].Value);
            dgvPedidos.DataSource = lista;
            dgvPedidos.Columns.Remove("IdAtendente");
            dgvPedidos.Columns.Remove("Atendente");
            dgvPedidos.Columns.Remove("CPF");
            dgvPedidos.Columns.Remove("NumeroPedidos");
            dgvPedidos.Columns.Remove("NumeroPratos");
            List<Pedidos> lista2 = pedido.ListarAtendimento();
            dgvAtendentes.DataSource = lista2;
            dgvAtendentes.Columns.Remove("IdPedido");
            dgvAtendentes.Columns.Remove("Cliente");
            dgvAtendentes.Columns.Remove("Mesa");
            dgvAtendentes.Columns.Remove("Pessoas");
            dgvAtendentes.Columns.Remove("Data");
            dgvAtendentes.Columns.Remove("Status");
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPedidos.Rows[e.RowIndex];
            FormDetalhesPedido dp = new FormDetalhesPedido((int)row.Cells[0].Value);
            dp.Show();
        }
    }
}
