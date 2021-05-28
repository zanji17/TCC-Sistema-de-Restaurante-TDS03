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

        public string cargo { get; set; }

        public bool voltar { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormHomeAtendente(int id, string tipo)
        {
            IdAtendente = id;
            cargo = tipo;
            InitializeComponent();
        }

        private void FormHomeAtendente_Load(object sender, EventArgs e)
        {
            voltar = false;
            Pedidos pedido = new Pedidos();
            pedido.LocalizaAtendente(IdAtendente);
            IdAtendente = pedido.IdAtendente;
            atualizar();
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
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMeusPedidos.Rows[e.RowIndex];
                using (FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value, (int)IdAtendente) { })
                {
                    if (rp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        atualizar();
                    }
                }
            }
        }

        private void dgvTodosPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTodosPedidos.Rows[e.RowIndex];
                using (FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value, (int)row.Cells[5].Value) { })
                {
                    if (rp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        atualizar();
                    }
                }
            }
        }

        public void atualizar()
        {
            Pedidos pedido = new Pedidos();
            List<Pedidos> meuspedidos = pedido.MeusPedidos(IdAtendente);
            dgvMeusPedidos.DataSource = meuspedidos;
            dgvMeusPedidos.Columns.Remove("Atendente");
            dgvMeusPedidos.Columns.Remove("IdAtendente");
            List<Pedidos> pedidosgeral = pedido.PedidosGeral(IdAtendente);
            dgvTodosPedidos.DataSource = pedidosgeral;
            nPessoas.Value = 1;
        }

        private void FormHomeAtendente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(cargo == "Atendente")
            {
                if(voltar == false)
                {
                    Environment.Exit(0);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
