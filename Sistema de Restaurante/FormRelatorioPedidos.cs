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
            dgvPedidos.Columns.Add("ID", "ID");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Data", "Data");
            dgvPedidos.Columns.Add("Status", "Status");
            dgvPedidos.Columns.Add("Atendente", "Atendente");
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalhesPedido detalhespedido = new FormDetalhesPedido();
            detalhespedido.Show();
        }
    }
}
