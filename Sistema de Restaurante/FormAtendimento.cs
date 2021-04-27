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
            dgvAtendentes.Columns.Add("ID", "ID");
            dgvAtendentes.Columns.Add("nome", "Nome");
            dgvAtendentes.Columns.Add("cpf", "CPF");
            dgvAtendentes.Columns.Add("pedidos", "Nº de Pedidos");
            dgvAtendentes.Columns.Add("pratos", "Nº Pratos");

            dgvPedidos.Columns.Add("ID", "ID");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Data", "Data");
            dgvPedidos.Columns.Add("Status", "Status");
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalhesPedido detalhespedido = new FormDetalhesPedido();
            detalhespedido.Show();
        }
    }
}
