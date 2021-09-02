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
    public partial class FormHomeAtendente : Form
    {
        public int IdAtendente { get; set; }

        public string cargo { get; set; }

        public bool voltar { get; set; }

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
            if (cargo == "Gerente")
            {
                IdAtendente = 0;
            }
            else
            {
                pedido.LocalizaAtendente(IdAtendente);
                IdAtendente = pedido.IdAtendente;
            }
            atualizar();
            dgvMeusPedidos.ClearSelection();
            dgvTodosPedidos.ClearSelection();
            Thread t = new Thread(new ThreadStart(atualizarTodosPedidos));
            t.Start();
        }

        public void atualizarTodosPedidos()
        {
            Pedidos pedido = new Pedidos();
            string resposta;
            while (true)
            {
                Thread.Sleep(1000);

                resposta = Atualizar.CountMeusPedidos(IdAtendente, dgvMeusPedidos.Rows.Count);
                if (resposta == "sim")
                {
                    List<Pedidos> meuspedidos = pedido.MeusPedidos(IdAtendente);
                    if (dgvMeusPedidos.InvokeRequired)
                    {
                        dgvMeusPedidos.Invoke((MethodInvoker)delegate
                        {
                            dgvMeusPedidos.DataSource = meuspedidos;
                            dgvMeusPedidos.Columns.Remove("Atendente");
                            dgvMeusPedidos.Columns.Remove("IdAtendente");
                            dgvMeusPedidos.Columns.Remove("NumeroPedidos");
                            dgvMeusPedidos.Columns.Remove("NumeroPratos");
                            dgvMeusPedidos.Columns.Remove("CPF");
                            dgvMeusPedidos.Columns.Remove("Status");
                            dgvMeusPedidos.Columns.Remove("endereco");
                            dgvMeusPedidos.Columns.Remove("bairro");
                            dgvMeusPedidos.Columns.Remove("complemento");
                            dgvMeusPedidos.Columns.Remove("telefone");
                        });
                    }
                }

                resposta = Atualizar.CountTodosPedidos(IdAtendente, dgvTodosPedidos.Rows.Count);
                if (resposta == "sim")
                {
                    List<Pedidos> pedidosgeral = pedido.PedidosGeral(IdAtendente);
                    if (dgvTodosPedidos.InvokeRequired)
                    {
                        dgvTodosPedidos.Invoke((MethodInvoker)delegate
                        {
                            dgvTodosPedidos.DataSource = pedidosgeral;
                            dgvTodosPedidos.Columns.Remove("NumeroPedidos");
                            dgvTodosPedidos.Columns.Remove("NumeroPratos");
                            dgvTodosPedidos.Columns.Remove("CPF");
                            dgvTodosPedidos.Columns.Remove("Status");
                            dgvTodosPedidos.Columns.Remove("endereco");
                            dgvTodosPedidos.Columns.Remove("bairro");
                            dgvTodosPedidos.Columns.Remove("complemento");
                            dgvTodosPedidos.Columns.Remove("telefone");
                        });
                    }
                }

                for (int i = 0; i < dgvMeusPedidos.RowCount; i++)
                {
                    resposta = Atualizar.VerPronto((int)dgvMeusPedidos.Rows[i].Cells[0].Value);
                    if (resposta == "sim")
                    {
                        if (dgvMeusPedidos.Rows[i].DefaultCellStyle.BackColor != Color.Gold)
                        {
                            dgvMeusPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        }
                    }
                    else
                    {
                        dgvMeusPedidos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnCriarPedidoAtendente_Click(object sender, EventArgs e)
        {
            if ((txtMesa.Text != "" && txtMesa.Text != null) && (nPessoas.Value > 0) && (txtCliente.Text != "" && txtCliente.Text != null))
            {
                Pedidos pedido = new Pedidos();
                pedido.CriarPedido(IdAtendente, txtCliente.Text.ToString().Trim(), txtMesa.Text.ToString().Trim(), (int)nPessoas.Value);
                using (FormRegistroPedido rp = new FormRegistroPedido((int)pedido.IdPedido) { })
                {
                    if (rp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        atualizar();
                    }
                }
                txtMesa.Text = string.Empty;
                txtCliente.Text = string.Empty;
            }
        }

        public void atualizar()
        {
            Pedidos pedido = new Pedidos();
            List<Pedidos> meuspedidos = pedido.MeusPedidos(IdAtendente);
            dgvMeusPedidos.DataSource = meuspedidos;
            dgvMeusPedidos.Columns.Remove("Atendente");
            dgvMeusPedidos.Columns.Remove("IdAtendente");
            dgvMeusPedidos.Columns.Remove("NumeroPedidos");
            dgvMeusPedidos.Columns.Remove("NumeroPratos");
            dgvMeusPedidos.Columns.Remove("CPF");
            dgvMeusPedidos.Columns.Remove("Status");
            dgvMeusPedidos.Columns.Remove("endereco");
            dgvMeusPedidos.Columns.Remove("bairro");
            dgvMeusPedidos.Columns.Remove("complemento");
            dgvMeusPedidos.Columns.Remove("telefone");
            List<Pedidos> pedidosgeral = pedido.PedidosGeral(IdAtendente);
            dgvTodosPedidos.DataSource = pedidosgeral;
            dgvTodosPedidos.Columns.Remove("Atendente");
            dgvTodosPedidos.Columns.Remove("IdAtendente");
            dgvTodosPedidos.Columns.Remove("NumeroPedidos");
            dgvTodosPedidos.Columns.Remove("NumeroPratos");
            dgvTodosPedidos.Columns.Remove("CPF");
            dgvTodosPedidos.Columns.Remove("Status");
            dgvTodosPedidos.Columns.Remove("endereco");
            dgvTodosPedidos.Columns.Remove("bairro");
            dgvTodosPedidos.Columns.Remove("complemento");
            dgvTodosPedidos.Columns.Remove("telefone");
            nPessoas.Value = 1;
            dgvTodosPedidos.ClearSelection();
            dgvMeusPedidos.ClearSelection();
        }

        private void dgvTodosPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTodosPedidos.Rows[e.RowIndex];
                using (FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value) { })
                {
                    if (rp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        atualizar();
                    }
                }
            }
        }

        private void dgvMeusPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMeusPedidos.Rows[e.RowIndex];
                using (FormRegistroPedido rp = new FormRegistroPedido((int)row.Cells[0].Value) { })
                {
                    if (rp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        atualizar();
                    }
                }
            }
        }

        private void FormHomeAtendente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cargo == "Atendente")
            {
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
