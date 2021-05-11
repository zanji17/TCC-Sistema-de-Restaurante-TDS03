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
        public int IdCozinha { get; set; }

        public FormHomeCozinha(int id)
        {
            IdCozinha = id;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            List<RegistroPedido> lista = registro.listaConfirmados();
            dgvPratoConfirmado.DataSource = lista;
        }
    }
}
