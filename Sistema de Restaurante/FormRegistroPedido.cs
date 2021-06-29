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
    public partial class FormRegistroPedido : Form
    {
        public int IdPedido { get; set; }

        public int IdAtendente { get; set; }

        public int Row { get; set; }

        public int Count { get; set; }

        public int Coluna { get; set; }

        public FormRegistroPedido(int idpedido, int idatendente)
        {
            IdPedido = idpedido;
            IdAtendente = idatendente;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using(FormRegistrarPrato rp = new FormRegistrarPrato(IdPedido, 0) { })
            {
                if(rp.ShowDialog() == DialogResult.OK)
                {
                    atualizaDGV();
                }
            }
        }

        private void FormRegistroPedido_Load(object sender, EventArgs e)
        {
            RegistroPedido rp = new RegistroPedido();
            rp.Localizar(IdPedido);
            lblMesaDelivery.Text = rp.Mesa;
            lblCliente.Text = rp.Cliente;
            lblPedido.Text = "Pedido: "+IdPedido;
            atualizaDGV();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            for (var i=0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[8].Value == "" || (string)dgvRegistro.Rows[i].Cells[8].Value == null)
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.Confirmar((int)dgvRegistro.Rows[i].Cells[0].Value, IdAtendente);
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
                    registro.Servido((int)dgvRegistro.Rows[Row].Cells[0].Value);
                    atualizaDGV();
                }
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows != null || dgvRegistro.SelectedCells != null)
            {
                if(dgvRegistro.SelectedRows == null)
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

        private void btnDel_Click(object sender, EventArgs e)
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

        private void btnCancelarTudo_Click(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo cancelar todos os registros?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                {
                    if(dgvRegistro.Rows[i].Cells[8].Value.ToString() == "Confirmado")
                    {
                        registro.Cancelado((int)dgvRegistro.Rows[i].Cells[0].Value);
                    }
                }
                if(DialogResult.Yes == MessageBox.Show("Deseja Apagar todos os registros vazios?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[8].Value.ToString() == "")
                        {
                            registro.DeletarPrato((int)dgvRegistro.Rows[i].Cells[0].Value);
                            registro.DeletarAdicionaisRetirados((int)dgvRegistro.Rows[i].Cells[0].Value);
                        }
                    }
                }
                atualizaDGV();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo cancelar esse pedido?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                var servido = false;
                for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                {
                    if(dgvRegistro.Rows[i].Cells[8].Value.ToString().Trim() == "Servido")
                    {
                        servido = true;
                    }
                }
                if (servido == false)
                {
                    Pedidos pedido = new Pedidos();
                    pedido.CancelaPedido(IdPedido);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não é possível apagar esse pedido. Pois há registro de prato servido!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormRegistroPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
