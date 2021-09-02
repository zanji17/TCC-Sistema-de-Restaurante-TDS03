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
    public partial class FormRegistroPedido : Form
    {
        public int IdPedido { get; set; }

        public int IdAtendente { get; set; }

        public int Row { get; set; }

        public int Count { get; set; }

        public int Coluna { get; set; }

        public FormRegistroPedido(int idpedido)
        {
            IdPedido = idpedido;
            InitializeComponent();
        }

        public void AtualizaAuto()
        {
            while (true)
            {
                Thread.Sleep(1000);
                int count = 0;
                for (int i = 0; i < dgvRegistro.RowCount; i++)
                {
                    if ((string)dgvRegistro.Rows[i].Cells[8].Value == "Pronto")
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

        private void FormRegistroPedido_Load(object sender, EventArgs e)
        {
            RegistroPedido rp = new RegistroPedido();
            List<RegistroPedido> lista = rp.listaPratos(IdPedido);
            dgvRegistro.DataSource = lista;
            dgvRegistro.Columns.Remove("Mesa");
            dgvRegistro.Columns.Remove("Cliente");
            dgvRegistro.Columns.Remove("IdPedido");
            dgvRegistro.Columns[0].Width = 45;
            dgvRegistro.Columns[1].Width = 50;
            dgvRegistro.Columns[8].HeaderText = "Situação";
            dgvRegistro.Columns[1].HeaderText = "Qtd";
            dgvRegistro.Columns[2].HeaderText = "Prato/Produto";
            for (int i = 0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[8].Value == "Pronto")
                {
                    dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }
            }

            rp.Localizar(IdPedido);
            lblMesa.Text = rp.Mesa;
            lblCliente.Text = rp.Cliente;
            Pedidos p = new Pedidos();
            p.BuscaAtendente(IdPedido);
            IdAtendente = p.IdAtendente;
            dgvRegistro.ClearSelection();
            Row = 0;
            dgvRegistro.ClearSelection();
            Thread t = new Thread(new ThreadStart(AtualizaAuto));
            t.Start();
        }

        private void btnConfirmado_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[8].Value == "" || (string)dgvRegistro.Rows[i].Cells[8].Value == null)
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.Confirmar((int)dgvRegistro.Rows[i].Cells[0].Value, IdAtendente);
                    atualizaDGV();
                }
            }
        }

        private void btnServidos_Click(object sender, EventArgs e)
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
                if (dgvRegistro.Rows[Row].Cells[8].Value.ToString() == "Pronto")
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
            if (dgvRegistro.InvokeRequired)
            {
                dgvRegistro.Invoke((MethodInvoker)delegate
                {
                    dgvRegistro.DataSource = lista;
                    dgvRegistro.Columns.Remove("Mesa");
                    dgvRegistro.Columns.Remove("Cliente");
                    dgvRegistro.Columns.Remove("IdPedido");
                    dgvRegistro.Columns[0].Width = 45;
                    dgvRegistro.Columns[1].Width = 50;
                    dgvRegistro.Columns[8].HeaderText = "Situação";
                    dgvRegistro.Columns[1].HeaderText = "Qtd";
                    dgvRegistro.Columns[2].HeaderText = "Prato/Produto";
                    for (int i = 0; i < dgvRegistro.RowCount; i++)
                    {
                        if ((string)dgvRegistro.Rows[i].Cells[8].Value == "Pronto")
                        {
                            dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        }
                    }
                    dgvRegistro.ClearSelection();
                    Row = 0;
                });
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
                    using (sugestao sg = new sugestao("Deseja mesmo apagar esse registro?"){ })
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

        private void btnCancelarTudo_Click(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            using(sugestao sg = new sugestao("Deseja mesmo cancelar todos os registros?") { })
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[8].Value.ToString() == "Confirmado")
                        {
                            registro.Cancelado((int)dgvRegistro.Rows[i].Cells[0].Value);
                        }
                    }
                    using(sugestao sg2 = new sugestao("Deseja Apagar todos os registros vazios?") { })
                    {
                        if (DialogResult.Yes == sg2.ShowDialog())
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
                    }
                    atualizaDGV();
                }
            }
        }

        private void btnCancelarPedidos_Click(object sender, EventArgs e)
        {
            using(sugestao sg = new sugestao("Deseja mesmo cancelar esse pedido?") { })
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    var servido = false;
                    for (int i = 0; i < dgvRegistro.Rows.Count; i++)
                    {
                        if (dgvRegistro.Rows[i].Cells[8].Value.ToString().Trim() == "Servido")
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
                        using (erro er = new erro("Não é possível apagar esse pedido. Pois há registro de prato servido!") { })
                        {

                        }
                    }
                }
            }
        }

        private void FormRegistroPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}