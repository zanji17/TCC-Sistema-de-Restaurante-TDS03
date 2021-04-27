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
        public FormHomeCaixa()
        {
            InitializeComponent();
        }

        private void FormHomeCaixa_Load(object sender, EventArgs e)
        {
            dgvPedidosAbertos.Columns.Add("ID", "ID");
            dgvPedidosAbertos.Columns.Add("Mesa_Delivery", "Mesa/Delivery");
            dgvPedidosAbertos.Columns.Add("Data", "Data");
            dgvPedidosAbertos.Columns.Add("Status", "Status");

            dgvRegistroPedido.Columns.Add("ID", "ID");
            dgvRegistroPedido.Columns.Add("Pratos_Produtos", "Pratos/Produtos");
            dgvRegistroPedido.Columns.Add("Quantidade", "Quantidade");
            dgvRegistroPedido.Columns.Add("Adicional", "Adicional");
            dgvRegistroPedido.Columns.Add("Retirar", "Retirar");
            dgvRegistroPedido.Columns.Add("Data", "Data");
            dgvRegistroPedido.Columns.Add("Status", "Status");
        }
    }
}
