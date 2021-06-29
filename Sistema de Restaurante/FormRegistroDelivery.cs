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
        }

        public void atualizaDGV()
        {
            RegistroPedido registro = new RegistroPedido();
            List<RegistroPedido> lista = registro.listaPratos(IdPedido);
            dgvRegistro.DataSource = lista;
            dgvRegistro.Columns.Remove("Mesa");
            dgvRegistro.Columns.Remove("Cliente");
            dgvRegistro.Columns.Remove("IdPedido");
            dgvRegistro.ClearSelection();
            Row = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (FormRegistrarPrato rp = new FormRegistrarPrato(IdPedido, 0) { })
            {
                if (rp.ShowDialog() == DialogResult.OK)
                {
                    atualizaDGV();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[8].Value == "" || (string)dgvRegistro.Rows[i].Cells[8].Value == null)
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.ConfirmarDelivery((int)dgvRegistro.Rows[i].Cells[0].Value);
                    atualizaDGV();
                }
            }
        }

        private void btnServido_Click(object sender, EventArgs e)
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
                if (dgvRegistro.Rows[Row].Cells[8].Value.ToString() == "Confirmado")
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.Pronto((int)dgvRegistro.Rows[Row].Cells[0].Value);
                    atualizaDGV();
                }
            }
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
                if (dgvRegistro.Rows[Row].Cells[8].Value.ToString() != "Servido")
                {
                    if (DialogResult.Yes == MessageBox.Show("Deseja mesmo cancelar esse registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        RegistroPedido registro = new RegistroPedido();
                        registro.Cancelado((int)dgvRegistro.Rows[Row].Cells[0].Value);
                        atualizaDGV();
                    }
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
                if (dgvRegistro.Rows[Row].Cells[8].Value.ToString() == null || dgvRegistro.Rows[Row].Cells[8].Value.ToString() == "")
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
                if (dgvRegistro.Rows[Row].Cells[8].Value.ToString() == null || dgvRegistro.Rows[Row].Cells[8].Value.ToString() == "")
                {
                    if (DialogResult.Yes == MessageBox.Show("Deseja mesmo apagar esse registro?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        RegistroPedido registro = new RegistroPedido();
                        registro.DeletarPrato((int)dgvRegistro.Rows[Row].Cells[0].Value);
                        registro.DeletarAdicionaisRetirados((int)dgvRegistro.Rows[Row].Cells[0].Value);
                        atualizaDGV();
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
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo cancelar esse pedido?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                {
                    if (dgvRegistro.Rows[i].Cells[8].Value.ToString() == "Confirmado")
                    {
                        registro.Cancelado((int)dgvRegistro.Rows[i].Cells[0].Value);
                    }
                }
                for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                {
                    if (dgvRegistro.Rows[i].Cells[8].Value.ToString() == "")
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

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem Certeza Que Deseja Fechar esse Pedido?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                var confirmado = false;
                for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                {
                    if (dgvRegistro.Rows[i].Cells[8].Value.ToString() == "Confirmado" || dgvRegistro.Rows[i].Cells[8].Value.ToString() == "")
                    {
                        confirmado = true;
                    }
                }
                RegistroPedido registro = new RegistroPedido();
                if (confirmado == false)
                {
                    registro.fecharPedido(IdPedido);
                    MessageBox.Show("O Pedido Foi Finalizado com Sucesso!", "Fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
