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
            Pedidos pedidos = new Pedidos();
            List<Pedidos> pedido = pedidos.PedidosRelatorio();
            dgvPedidos.DataSource = pedido;
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPedidos.Rows[e.RowIndex];
            FormDetalhesPedido detalhespedido = new FormDetalhesPedido((int)row.Cells[0].Value);
            detalhespedido.Show();
        }
    }
}
