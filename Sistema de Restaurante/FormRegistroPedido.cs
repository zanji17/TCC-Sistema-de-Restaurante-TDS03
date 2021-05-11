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

        public FormRegistroPedido(int idpedido, int idatendente)
        {
            IdPedido = idpedido;
            IdAtendente = idatendente;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPrato rp = new FormRegistrarPrato(IdPedido);
            rp.Show();
        }

        private void FormRegistroPedido_Load(object sender, EventArgs e)
        {
            RegistroPedido rp = new RegistroPedido();
            rp.Localizar(IdPedido);
            lblMesaDelivery.Text = rp.Mesa;
            lblCliente.Text = rp.Cliente;
            lblPedido.Text = "Pedido: "+IdPedido;  
            List <RegistroPedido> lista = rp.listaPratos(IdPedido);
            dgvRegistro.DataSource = lista;
            dgvRegistro.Columns.Remove("Mesa");
            dgvRegistro.Columns.Remove("Cliente");
            dgvRegistro.Columns.Remove("IdPedido");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            for (var i=0; i < dgvRegistro.RowCount; i++)
            {
                if ((string)dgvRegistro.Rows[i].Cells[8].Value == "" || (string)dgvRegistro.Rows[i].Cells[8].Value == null)
                {
                    RegistroPedido registro = new RegistroPedido();
                    registro.Confirmar((int)dgvRegistro.Rows[i].Cells[0].Value, IdAtendente);
                    List<RegistroPedido> lista = registro.listaPratos(IdPedido);
                    dgvRegistro.DataSource = lista;
                    dgvRegistro.Columns.Remove("Mesa");
                    dgvRegistro.Columns.Remove("Cliente");
                    dgvRegistro.Columns.Remove("IdPedido");
                }
            }
        }
    }
}
