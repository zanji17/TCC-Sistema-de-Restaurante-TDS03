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
        public FormRegistroPedido()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPrato rp = new FormRegistrarPrato();
            rp.Show();
        }
    }
}
