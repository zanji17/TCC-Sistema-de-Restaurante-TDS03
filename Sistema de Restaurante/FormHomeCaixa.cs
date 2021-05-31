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
        }

        private void dgvPedidosAbertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPedidosAbertos.Rows[e.RowIndex];
                List<RegistroPedido> lista = registro.listaPratos((int)row.Cells[0].Value);
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
                    RegistroPedido registro = new RegistroPedido();
                    registro.fecharPedido((int)dgvPedidosAbertos.Rows[Row].Cells[0].Value);
                    MessageBox.Show("O Pedido Foi Finalizado com Sucesso!", "Fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarDGV();
                }
            }
        }

        public void atualizarDGV()
        {
            Pedidos pedidos = new Pedidos();
            List<Pedidos> pedido = pedidos.PedidosCaixa();
            dgvPedidosAbertos.DataSource = pedido;
            dgvPedidosAbertos.Columns.Remove("CPF");
            dgvPedidosAbertos.Columns.Remove("NumeroPedidos");
            dgvPedidosAbertos.Columns.Remove("NumeroPratos");
            dgvPedidosAbertos.Columns.Remove("Status");
            dgvRegistroPedido.Columns.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvRegistroPedido.Columns.Clear();
            dgvPedidosAbertos.ClearSelection();
        }
    }
}
