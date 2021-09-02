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
using System.Threading;

namespace Restaurante
{
    public partial class FormDelivery : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormDelivery()
        {
            InitializeComponent();
        }

        private void btnCriarPedidoAtendente_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != null && txtNome.Text != "") && (txtEndereco.Text != null && txtEndereco.Text != ""))
            {
                Pedidos pedido = new Pedidos();
                pedido.CriarPedidoDelivery(txtNome.Text, txtTelefone.Text, txtEndereco.Text, txtBairro.Text, txtComplemento.Text);
                FormRegistroDelivery rd = new FormRegistroDelivery((int)pedido.IdPedido);
                rd.Show();
                txtNome.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtComplemento.Text = string.Empty;
            }
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            atualizarDGV();
            Thread t = new Thread(new ThreadStart(AtualizaAuto));
            t.Start();
        }

        public void AtualizaAuto()
        {
            string resposta;
            while (true)
            {
                Thread.Sleep(1000);
                resposta = Atualizar.CountPedidosDelivery(dgvAberto.Rows.Count);
                if (resposta == "sim")
                {
                    atualizarDGV();
                    dgvAberto.ClearSelection();
                }
                for (int i = 0; i < dgvAberto.RowCount; i++)
                {
                    resposta = Atualizar.VerPronto((int)dgvAberto.Rows[i].Cells[0].Value);
                    if (resposta == "sim")
                    {
                        if (dgvAberto.Rows[i].DefaultCellStyle.BackColor != Color.Gold)
                        {
                            dgvAberto.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        }
                    }
                    else
                    {
                        dgvAberto.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        public void atualizarDGV()
        {
            Pedidos pedido = new Pedidos();
            List<Pedidos> lista = pedido.PedidosAbertosDelivery();
            List<Pedidos> lista2 = pedido.PedidosFinalizadosDelivery();
            if (dgvAberto.InvokeRequired)
            {
                dgvAberto.Invoke((MethodInvoker)delegate
                {
                    dgvAberto.DataSource = lista;
                    dgvAberto.Columns.Remove("Mesa");
                    dgvAberto.Columns.Remove("Pessoas");
                    dgvAberto.Columns.Remove("IdAtendente");
                    dgvAberto.Columns.Remove("Atendente");
                    dgvAberto.Columns.Remove("Status");
                    dgvAberto.Columns.Remove("CPF");
                    dgvAberto.Columns.Remove("NumeroPedidos");
                    dgvAberto.Columns.Remove("NumeroPratos");
                    dgvAberto.Columns.Remove("endereco");
                    dgvAberto.Columns.Remove("bairro");
                    dgvAberto.Columns.Remove("complemento");
                    dgvAberto.Columns.Remove("telefone");
                    dgvAberto.ClearSelection();
                });
            }
            if (dgvFinalizado.InvokeRequired)
            {
                dgvFinalizado.Invoke((MethodInvoker)delegate
                {
                    dgvFinalizado.DataSource = lista2;
                    dgvFinalizado.Columns.Remove("Mesa");
                    dgvFinalizado.Columns.Remove("Pessoas");
                    dgvFinalizado.Columns.Remove("IdAtendente");
                    dgvFinalizado.Columns.Remove("Atendente");
                    dgvFinalizado.Columns.Remove("CPF");
                    dgvFinalizado.Columns.Remove("NumeroPedidos");
                    dgvFinalizado.Columns.Remove("NumeroPratos");
                    dgvFinalizado.Columns.Remove("endereco");
                    dgvFinalizado.Columns.Remove("bairro");
                    dgvFinalizado.Columns.Remove("complemento");
                    dgvFinalizado.Columns.Remove("telefone");
                    dgvFinalizado.Columns[3].HeaderText = "Situação";
                    dgvFinalizado.ClearSelection();
                });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != null && txtNome.Text != "")
            {
                Pedidos pedido = new Pedidos();
                pedido.EditarInfoCliente(txtNome.Text, txtTelefone.Text, txtEndereco.Text, txtBairro.Text, txtComplemento.Text);
                txtNome.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtComplemento.Text = string.Empty;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sugestaocliente = new AutoCompleteStringCollection();
            Pedidos pedido = new Pedidos();
            List<Pedidos> lista = pedido.listarClientes();
            for (int i = 0; i < lista.Count; i++)
            {
                sugestaocliente.Add(lista[i].Cliente);
            }
            txtNome.AutoCompleteCustomSource = sugestaocliente;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            List<Pedidos> lista = pedido.BuscaCliente(txtNome.Text);
            if (lista.Count > 0)
            {
                txtTelefone.Text = lista[0].telefone;
                txtEndereco.Text = lista[0].endereco;
                txtBairro.Text = lista[0].bairro;
                txtComplemento.Text = lista[0].complemento;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAberto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAberto.Rows[e.RowIndex];
                FormRegistroDelivery rd = new FormRegistroDelivery((int)row.Cells[0].Value);
                rd.Show();
            }
        }

        private void dgvFinalizado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFinalizado.Rows[e.RowIndex];
                FormDetalhesPedido dp = new FormDetalhesPedido((int)row.Cells[0].Value);
                dp.Show();
            }
        }
    }
}
