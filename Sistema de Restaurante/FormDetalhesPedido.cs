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
        }
    }
}
