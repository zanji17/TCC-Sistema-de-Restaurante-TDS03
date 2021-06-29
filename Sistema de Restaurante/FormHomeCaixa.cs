using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Restaurante
{
    public partial class FormHomeCaixa : Form
    {
        public int IdCaixa { get; set; }

        public int Row { get; set; }

        public FormHomeCaixa(int id)
        {
            IdCaixa = id;
            InitializeComponent();
        }

        private void FormHomeCaixa_Load(object sender, EventArgs e)
        {
            atualizarDGV();
            Thread t = new Thread(new ThreadStart(atualizarPedidos));
            t.Start();
        }

        public void atualizarPedidos()
        {
            string resposta;
            while (true)
            {
                Thread.Sleep(1000);
                resposta = Atualizar.CountPedidosCaixa(dgvPedidosAbertos.Rows.Count);
                if(resposta == "sim")
                {
                    atualizarDGV();
                }
            }
        }

        private void dgvPedidosAbertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            lblPedido.Text = string.Empty;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPedidosAbertos.Rows[e.RowIndex];
                List<RegistroPedido> lista = registro.listaPratos((int)row.Cells[0].Value);
                lblPedido.Text = row.Cells[0].Value.ToString();
                dgvRegistroPedido.DataSource = lista;
                dgvRegistroPedido.Columns.Remove("Cliente");
                dgvRegistroPedido.Columns.Remove("Mesa");
                dgvRegistroPedido.Columns.Remove("Atendente");
                dgvRegistroPedido.Columns.Remove("IdPedido");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem Certeza Que Deseja Fechar esse Pedido?","Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (dgvPedidosAbertos.SelectedRows != null || dgvPedidosAbertos.SelectedCells != null)
                {
                    if(dgvPedidosAbertos.SelectedRows == null)
                    {
                        Row = dgvPedidosAbertos.CurrentCell.RowIndex;
                    }
                    else
                    {
                        Row = dgvPedidosAbertos.CurrentRow.Index;
                    }
                    var confirmado = false;
                    for (int i = 0; i < dgvRegistroPedido.Rows.Count; i++)
                    {
                        if (dgvRegistroPedido.Rows[i].Cells[7].Value.ToString() == "Confirmado" || dgvRegistroPedido.Rows[i].Cells[7].Value.ToString() == "")
                        {
                            confirmado = true;
                        }
                    }
                    RegistroPedido registro = new RegistroPedido();
                    if (confirmado == false)
                    {
                        registro.fecharPedido((int)dgvPedidosAbertos.Rows[Row].Cells[0].Value);
                        MessageBox.Show("O Pedido Foi Finalizado com Sucesso!", "Fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizarDGV();
                        dgvRegistroPedido.Columns.Clear();
                    }
                }
            }
        }

        public void atualizarDGV()
        {
            Pedidos pedidos = new Pedidos();
            List<Pedidos> pedido = pedidos.PedidosCaixa();
            if (dgvPedidosAbertos.InvokeRequired)
            {
                dgvPedidosAbertos.Invoke((MethodInvoker)delegate
                {
                    dgvPedidosAbertos.DataSource = pedido;
                    dgvPedidosAbertos.Columns.Remove("CPF");
                    dgvPedidosAbertos.Columns.Remove("NumeroPedidos");
                    dgvPedidosAbertos.Columns.Remove("NumeroPratos");
                    dgvPedidosAbertos.Columns.Remove("Status");
                    dgvPedidosAbertos.Columns.Remove("endereco");
                    dgvPedidosAbertos.Columns.Remove("bairro");
                    dgvPedidosAbertos.Columns.Remove("complemento");
                    dgvPedidosAbertos.Columns.Remove("telefone");
                });
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvRegistroPedido.Columns.Clear();
            dgvPedidosAbertos.ClearSelection();
            lblPedido.Text = string.Empty;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            FormDelivery d = new FormDelivery();
            d.Show();
        }
    }
}
