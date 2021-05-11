using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class FormHomeAtendente : Form
    {
        public int IdAtendente { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormHomeAtendente(int id)
        {
            IdAtendente = id;
            InitializeComponent();
        }

        private void FormHomeAtendente_Load(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.LocalizaAtendente(IdAtendente);
            IdAtendente = pedido.IdAtendente;
            List<Pedidos> meuspedidos = pedido.MeusPedidos(IdAtendente);
            dgvMeusPedidos.DataSource = meuspedidos;
            dgvMeusPedidos.Columns.Remove("Atendente");
            dgvMeusPedidos.Columns.Remove("IdAtendente");
            List<Pedidos> pedidosgeral = pedido.PedidosGeral(IdAtendente);
            dgvTodosPedidos.DataSource = pedidosgeral;
        }

        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            if((txtMesa.Text != "" && txtMesa.Text != null) && (nPessoas.Value > 0) && (txtCliente.Text != "" && txtCliente.Text != null))
            {
                Pedidos pedido = new Pedidos();
                pedido.CriarPedido(IdAtendente, txtCliente.Text.ToString().Trim(), txtMesa.Text.ToString().Trim(), (int)nPessoas.Value);
                FormRegistroPedido rp = new FormRegistroPedido((int)pedido.IdPedido, (int)IdAtendente);
                rp.Show();
            }
        }

        private void dgvMeusPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvMeusPedidos.Rows[e.RowIndex];
            FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value, (int)IdAtendente);
            rp.Show();
        }

        private void dgvTodosPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvMeusPedidos.Rows[e.RowIndex];
            FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value, (int)row.Cells[5].Value);
            rp.Show();
        }
    }
}
