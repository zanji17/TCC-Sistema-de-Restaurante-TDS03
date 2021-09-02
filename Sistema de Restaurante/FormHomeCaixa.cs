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
        public string cargo { get; set; }

        public int Row { get; set; }

        public FormHomeCaixa(string tipo)
        {
            cargo = tipo;
            InitializeComponent();
        }

        private void FormHomeCaixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cargo == "Caixa")
            {
                Application.Exit();
            }
        }
        public void atualizarPedidos()
        {
            string resposta;
            while (true)
            {
                Thread.Sleep(1000);
                resposta = Atualizar.CountPedidosCaixa(dgvPedidosAbertos.Rows.Count);
                if (resposta == "sim")
                {
                    atualizarDGV();
                }
            }
        }

        private void FormHomeCaixa_Load(object sender, EventArgs e)
        {
            atualizarDGV();
            Thread t = new Thread(new ThreadStart(atualizarPedidos));
            txtAumDim.Text = "R$0,00";
            t.Start();
            dgvPedidosAbertos.ClearSelection();
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

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPedidosAbertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            lblMesa.Text = string.Empty;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPedidosAbertos.Rows[e.RowIndex];
                List<RegistroPedido> lista = registro.listaPratos((int)row.Cells[0].Value);
                lblMesa.Text = row.Cells[2].Value.ToString();
                dgvRegistroPedido.DataSource = lista;
                dgvRegistroPedido.Columns.Remove("Cliente");
                dgvRegistroPedido.Columns.Remove("Mesa");
                dgvRegistroPedido.Columns.Remove("Atendente");
                dgvRegistroPedido.Columns.Remove("IdPedido");
                dgvRegistroPedido.Columns[0].Width = 50;
                dgvRegistroPedido.Columns[1].HeaderText = "Qtd";
                dgvRegistroPedido.Columns[1].Width = 45;
                dgvRegistroPedido.Columns[2].HeaderText = "Prato/Produto";
                dgvRegistroPedido.Columns[7].HeaderText = "Situação";
                txtAumDim.Text = "R$0,00";
                txtDesconto.Text = string.Empty;
                int valor=0;
                string valorEscrito;
                for (int i = 0; i < dgvRegistroPedido.RowCount; i++)
                {
                    valor += Convert.ToInt32(dgvRegistroPedido.Rows[i].Cells[8].Value.ToString().Replace("R$", "").Replace(",", "").Replace(".", ""));
                }
                valorEscrito = Convert.ToString(valor);
                while (valorEscrito.Length < 3)
                {
                    valorEscrito = "0" + valorEscrito;
                }
                lblTotal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
                lblValorFinal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
            }
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem Certeza Que Deseja Fechar esse Pedido?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (dgvPedidosAbertos.SelectedRows != null || dgvPedidosAbertos.SelectedCells != null)
                {
                    if (dgvPedidosAbertos.SelectedRows == null)
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
                        using (sucesso sc = new sucesso() { })
                        {
                            if (DialogResult.OK == sc.ShowDialog())
                            {

                            }
                        }
                        atualizarDGV();
                        txtAumDim.Text = "R$0,00";
                        dgvRegistroPedido.Columns.Clear();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvRegistroPedido.Columns.Clear();
            dgvPedidosAbertos.ClearSelection();
            lblMesa.Text = string.Empty;
            txtAumDim.Text = "R$0,00";
        }

        private void cbtnDelivery_Click(object sender, EventArgs e)
        {
            FormDelivery d = new FormDelivery();
            d.Show();
        }

        private void txtAumDim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtAumDim_TextChanged(object sender, EventArgs e)
        {
            string valor = txtAumDim.Text.Replace(",", "").Replace(".", "").Replace("R$", "");
            if (valor == "")
            {
                txtAumDim.Text = "R$0,00";
            }
            else if (valor.Length >= 4)
            {
                if (valor.Substring(0, 1) == "0")
                {
                    txtAumDim.Text = "R$" + valor.Substring(1, 1) + "," + valor.Substring(2, 2);
                }
                else
                {
                    txtAumDim.Text = "R$" + valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2, 2);
                }
            }
            else if (valor.Length < 3)
            {
                txtAumDim.Text = "R$" + 0 + "," + valor;
            }
            else if(valor.Length == 3)
            {
                txtAumDim.Text = "R$" + valor.Substring(0, 1) + "," + valor.Substring(1, 2);
            }
            txtAumDim.SelectionStart = txtAumDim.Text.Length;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string valor = Convert.ToString(Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) + Convert.ToInt32(txtAumDim.Text.Replace("R$", "").Replace(",", "").Replace(".", "")));
            while (valor.Length < 3)
            {
                valor = "0" + valor;
            }
            lblValorFinal.Text = "R$" + valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2, 2);
            txtAumDim.Text = "R$0,00";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string valor = Convert.ToString(Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) - Convert.ToInt32(txtAumDim.Text.Replace("R$", "").Replace(",", "").Replace(".", "")));
            while (valor.Length < 3)
            {
                valor = "0" + valor;
            }
            lblValorFinal.Text = "R$" + valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2, 2);
            txtAumDim.Text = "R$0,00";
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            string valor = Convert.ToString(Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) - (Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) * (Convert.ToDouble(txtDesconto.Text)/100)));
            while (valor.Length < 3)
            {
                valor = "0" + valor;
            }
            lblValorFinal.Text = "R$" + valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2, 2);
            txtDesconto.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblValorFinal.Text = lblTotal.Text;
            txtAumDim.Text = "R$0,00";
            txtDesconto.Text = string.Empty;
        }
    }
}
