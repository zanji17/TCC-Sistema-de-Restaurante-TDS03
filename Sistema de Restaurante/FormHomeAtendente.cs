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
    public partial class FormHomeAtendente : Form
    {
        public FormHomeAtendente()
        {
            InitializeComponent();
        }

        private void FormHomeAtendente_Load(object sender, EventArgs e)
        {
            dgvMeusPedidos.Columns.Add("ID","ID");
            dgvMeusPedidos.Columns.Add("Mesa_Delivery", "Mesa/Delivery");
            dgvMeusPedidos.Columns.Add("Data", "Data");

            dgvTodosPedidos.Columns.Add("ID", "ID");
            dgvTodosPedidos.Columns.Add("Mesa_Delivery", "Mesa/Delivery");
            dgvTodosPedidos.Columns.Add("Data", "Data");
            dgvTodosPedidos.Columns.Add("Atendente", "Atendente");
        }

        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            FormRegistroPedido rp = new FormRegistroPedido();
            rp.Show();
        }
    }
}
