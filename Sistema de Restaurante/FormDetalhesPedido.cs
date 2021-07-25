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
    public partial class FormDetalhesPedido : Form
    {
        public int Id { get; set; }
        public FormDetalhesPedido(int IdPedido)
        {
            Id = IdPedido;
            InitializeComponent();
        }

        private void FormDetalhesPedido_Load(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            List<RegistroPedido> lista = registro.listaPratos(Id);
            dgvRegistro.DataSource = lista;
            dgvRegistro.Columns.Remove("Mesa");
            dgvRegistro.Columns.Remove("Cliente");
            dgvRegistro.Columns.Remove("IdPedido");
            dgvRegistro.Columns[8].HeaderText = "Situação";
            dgvRegistro.Columns[1].HeaderText = "Qtd";
            dgvRegistro.Columns[2].HeaderText = "Prato/Produto";
            dgvRegistro.Columns[0].Width = 45;
            dgvRegistro.Columns[1].Width = 50;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
