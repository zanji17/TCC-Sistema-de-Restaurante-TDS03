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
    public partial class FormHomeCaixa : Form
    {
        public int IdCaixa { get; set; }

        public FormHomeCaixa(int id)
        {
            IdCaixa = id;
            InitializeComponent();
        }

        private void FormHomeCaixa_Load(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            List<Pedidos> pedido = pedidos.PedidosCaixa();
            dgvPedidosAbertos.DataSource = pedido;
        }

        private void dgvPedidosAbertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            DataGridViewRow row = this.dgvPedidosAbertos.Rows[e.RowIndex];
            List<RegistroPedido> lista = registro.listaPratos((int)row.Cells[0].Value);
            dgvRegistroPedido.DataSource = lista;
        }
    }
}
