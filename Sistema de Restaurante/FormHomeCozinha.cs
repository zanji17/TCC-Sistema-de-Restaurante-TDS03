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
    public partial class FormHomeCozinha : Form
    {
        public FormHomeCozinha()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvPratoConfirmado.Columns.Add("ID", "ID");
            dgvPratoConfirmado.Columns.Add("Pedido", "Pedido");
            dgvPratoConfirmado.Columns.Add("PP", "Prato/Produto");
            dgvPratoConfirmado.Columns.Add("Quantidade", "Quantidade");
            dgvPratoConfirmado.Columns.Add("OBS", "OBS");
            dgvPratoConfirmado.Columns.Add("Adicional", "Adicional");
            dgvPratoConfirmado.Columns.Add("Retirar", "Retirar");
            dgvPratoConfirmado.Columns.Add("Data", "Data");
            dgvPratoConfirmado.Columns.Add("Atendete", "Atendente");
            dgvPratoConfirmado.Columns.Add("Status", "Status");
        }
    }
}
