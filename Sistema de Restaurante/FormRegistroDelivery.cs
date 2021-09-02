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
    public partial class FormRegistroDelivery : Form
    {
        public int IdPedido { get; set; }
        public string Cliente { get; set; }
        public int Row { get; set; }

        public FormRegistroDelivery(int idpedido)
        {
            InitializeComponent();
            IdPedido = idpedido;
        }

        public void AtualizaAuto()
        {
            while (true)
            {
                Thread.Sleep(1000);
                int count = 0;
                for (int i = 0; i < dgvRegistro.RowCount; i++)
                {
                    if ((string)dgvRegistro.Rows[i].Cells[7].Value == "Pronto")
                    {
                        count++;
                    }
                }
                string resposta = Atualizar.CountPronto(count, IdPedido);
                if (resposta == "sim")
                {
                    atualizaDGV();
                }
            }
        }

        private void FormRegistroDelivery_Load(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            RegistroPedido rp = new RegistroPedido();
            rp.Localizar(IdPedido);
            lblCliente.Text = rp.Cliente;
            Cliente = rp.Cliente;
            List<Pedidos> lista = pedido.BuscaCliente(Cliente);
            lblBairro.Text = lista[0].bairro;
            lblEndereco.Text = lista[0].endereco;
            lblTelefone.Text = lista[0].telefone;
            lblComplemento.Text = lista[0].complemento;
            atualizaDGV();
            dgvRegistro.ClearSelection();
            Thread t = new Thread(new ThreadStart(AtualizaAuto));
            t.Start();

            List<RegistroPedido> lista2 = rp.listaPratos(IdPedido);
            dgvRegistro.DataSource = lista2;
            dgvRegistro.Columns.Remove("Mesa");
            dgvRegistro.Columns.Remove("Cliente");
            dgvRegistro.Columns.Remove("IdPedido");
            dgvRegistro.Columns.Remove("Atendente");
            dgvRegistro.Columns[2].HeaderText = "Prato/Produto";
            dgvRegistro.Columns[1].HeaderText = "Qtd";
            dgvRegistro.Columns[7].HeaderText = "Situação";
            dgvRegistro.Columns[0].Width = 45;
            dgvRegistro.Columns[1].Width = 50;
            for (int i = 0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[7].Value == "Pronto")
                {
                    dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }
            }
            dgvRegistro.ClearSelection();
            Row = 0;
            txtAumDim.Text = "R$0,00";
            txtDesconto.Text = string.Empty;
            int valor = 0;
            string valorEscrito;
            for (int i = 0; i < dgvRegistro.RowCount; i++)
            {
                valor += Convert.ToInt32(dgvRegistro.Rows[i].Cells[8].Value.ToString().Replace("R$", "").Replace(",", "").Replace(".", ""));
            }
            valorEscrito = Convert.ToString(valor);
            while (valorEscrito.Length < 3)
            {
                valorEscrito = "0" + valorEscrito;
            }
            lblTotal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
            lblValorFinal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
        }

        public void atualizaDGV()
        {
            RegistroPedido registro = new RegistroPedido();
            List<RegistroPedido> lista = registro.listaPratos(IdPedido);
            if (dgvRegistro.InvokeRequired)
            {
                dgvRegistro.Invoke((MethodInvoker)delegate
                {
                    dgvRegistro.DataSource = lista;
                    dgvRegistro.Columns.Remove("Mesa");
                    dgvRegistro.Columns.Remove("Cliente");
                    dgvRegistro.Columns.Remove("IdPedido");
                    dgvRegistro.Columns.Remove("Atendente");
                    dgvRegistro.Columns[2].HeaderText = "Prato/Produto";
                    dgvRegistro.Columns[1].HeaderText = "Qtd";
                    dgvRegistro.Columns[7].HeaderText = "Situação";
                    dgvRegistro.Columns[0].Width = 45;
                    dgvRegistro.Columns[1].Width = 50;
                    for (int i = 0; i < dgvRegistro.RowCount; i++)
                    {
                        if ((string)dgvRegistro.Rows[i].Cells[7].Value == "Pronto")
                        {
                            dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        }
                    }
                    dgvRegistro.ClearSelection();
                    Row = 0;
                    txtAumDim.Text = "R$0,00";
                    txtDesconto.Text = string.Empty;
                    int valor = 0;
                    string valorEscrito;
                    for (int i = 0; i < dgvRegistro.RowCount; i++)
                    {
                        valor += Convert.ToInt32(dgvRegistro.Rows[i].Cells[8].Value.ToString().Replace("R$", "").Replace(",", "").Replace(".", ""));
                    }
                    valorEscrito = Convert.ToString(valor);
                    while (valorEscrito.Length < 3)
                    {
                        valorEscrito = "0" + valorEscrito;
                    }
                    lblTotal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
                    lblValorFinal.Text = "R$" + valorEscrito.Substring(0, valorEscrito.Length - 2) + "," + valorEscrito.Substring(valorEscrito.Length - 2, 2);
                });
            }
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            using (FormRegistrarPrato rp = new FormRegistrarPrato(IdPedido, 0) { })
            {
                if (rp.ShowDialog() == DialogResult.OK)
                {
                    atualizaDGV();
                }
            }
        }

        private void btnConfirmado_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[7].Value == "" || (string)dgvRegistro.Rows[i].Cells[7].Value == null)
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.ConfirmarDelivery((int)dgvRegistro.Rows[i].Cells[0].Value);
                    atualizaDGV();
                }
            }
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows != null || dgvRegistro.SelectedCells != null)
            {
                if (dgvRegistro.SelectedCells != null)
                {
                    Row = dgvRegistro.CurrentCell.RowIndex;
                }
                else
                {
                    Row = dgvRegistro.CurrentRow.Index;
                }
                if (dgvRegistro.Rows[Row].Cells[7].Value.ToString() == "Pronto")
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.OK((int)dgvRegistro.Rows[Row].Cells[0].Value);
                    atualizaDGV();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows != null || dgvRegistro.SelectedCells != null)
            {
                if (dgvRegistro.SelectedRows == null)
                {
                    Row = dgvRegistro.CurrentCell.RowIndex;
                }
                else
                {
                    Row = dgvRegistro.CurrentRow.Index;
                }
                if (dgvRegistro.Rows[Row].Cells[7].Value.ToString() == null || dgvRegistro.Rows[Row].Cells[7].Value.ToString() == "")
                {
                    using (FormRegistrarPrato rp = new FormRegistrarPrato(IdPedido, (int)dgvRegistro.Rows[Row].Cells[0].Value) { })
                    {
                        if (rp.ShowDialog() == DialogResult.OK)
                        {
                            atualizaDGV();
                        }
                    }
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows != null || dgvRegistro.SelectedCells != null)
            {
                if (dgvRegistro.SelectedRows == null)
                {
                    Row = dgvRegistro.CurrentCell.RowIndex;
                }
                else
                {
                    Row = dgvRegistro.CurrentRow.Index;
                }
                if (dgvRegistro.Rows[Row].Cells[7].Value.ToString() == null || dgvRegistro.Rows[Row].Cells[7].Value.ToString() == "")
                {
                    using(sugestao sg = new sugestao("Deseja mesmo apagar esse registro?") { })
                    {
                        if (DialogResult.Yes == sg.ShowDialog())
                        {
                            RegistroPedido registro = new RegistroPedido();
                            registro.DeletarPrato((int)dgvRegistro.Rows[Row].Cells[0].Value);
                            registro.DeletarAdicionaisRetirados((int)dgvRegistro.Rows[Row].Cells[0].Value);
                            atualizaDGV();
                        }
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            using(sugestao sg = new sugestao("Deseja mesmo cancelar esse pedido?") { })
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[7].Value.ToString() == "Confirmado")
                        {
                            registro.Cancelado((int)dgvRegistro.Rows[i].Cells[0].Value);
                        }
                    }
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[7].Value.ToString() == "")
                        {
                            registro.DeletarPrato((int)dgvRegistro.Rows[i].Cells[0].Value);
                            registro.DeletarAdicionaisRetirados((int)dgvRegistro.Rows[i].Cells[0].Value);
                        }
                    }
                    Pedidos pedido = new Pedidos();
                    pedido.CancelaPedido(IdPedido);
                    this.Close();
                }
            }
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            using (sugestao sg = new sugestao("Tem Certeza Que Deseja Fechar esse Pedido?") { }) 
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    var confirmado = false;
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[7].Value.ToString() == "Confirmado" || dgvRegistro.Rows[i].Cells[7].Value.ToString() == "")
                        {
                            confirmado = true;
                        }
                    }
                    RegistroPedido registro = new RegistroPedido();
                    if (confirmado == false)
                    {
                        registro.fecharPedido(IdPedido);
                        using(sucesso sc = new sucesso() { })
                        {

                        }
                        this.Close();
                    }
                }
            }
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows != null || dgvRegistro.SelectedCells != null)
            {
                if (dgvRegistro.SelectedRows == null)
                {
                    Row = dgvRegistro.CurrentCell.RowIndex;
                }
                else
                {
                    Row = dgvRegistro.CurrentRow.Index;
                }
                if (dgvRegistro.Rows[Row].Cells[7].Value.ToString() != "OK")
                {
                    using(sugestao sg = new sugestao("Deseja mesmo cancelar esse registro?") { })
                    {
                        if (DialogResult.Yes == sg.ShowDialog())
                        {
                            RegistroPedido registro = new RegistroPedido();
                            registro.Cancelado((int)dgvRegistro.Rows[Row].Cells[0].Value);
                            atualizaDGV();
                        }
                    }
                }
            }
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
            else if (valor.Length == 3)
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
            string valor = Convert.ToString(Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) - (Convert.ToInt32(lblValorFinal.Text.Replace("R$", "").Replace(",", "").Replace(".", "")) * (Convert.ToDouble(txtDesconto.Text) / 100)));
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
