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
        public FormDetalhesPedido()
        {
            InitializeComponent();
        }

        private void FormDetalhesPedido_Load(object sender, EventArgs e)
        {
            dgvRegistro.Columns.Add("ID", "ID");
            dgvRegistro.Columns.Add("PP", "Prato/Produto");
            dgvRegistro.Columns.Add("Quantidade", "Quantidade");
            dgvRegistro.Columns.Add("OBS", "OBS");
            dgvRegistro.Columns.Add("Adicional", "Adicional");
            dgvRegistro.Columns.Add("Retirar", "Retirar");
            dgvRegistro.Columns.Add("Data", "Data");
            dgvRegistro.Columns.Add("Atendete", "Atendente");
            dgvRegistro.Columns.Add("Status", "Status");
        }
    }
}
