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
    public partial class FormModeloAdicional : Form
    {
        public FormModeloAdicional()
        {
            InitializeComponent();
        }

        private void FormModeloAdicional_Load(object sender, EventArgs e)
        {
            ModeloAdicional modelo = new ModeloAdicional();
            List<ModeloAdicional> lista = modelo.listarModelos();
            dgvModelos.DataSource = lista;
        }

        private void clbAdicionais_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                lbAdicionais.Items.Add(clbAdicionais.SelectedItem);
            }
            else
            {
                lbAdicionais.Items.Remove(clbAdicionais.SelectedItem);
            }
        }

        private void dgvModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbAdicionais.ClearSelected();
            ModeloAdicional modelo = new ModeloAdicional();
            DataGridViewRow row = this.dgvModelos.Rows[e.RowIndex];
            txtNome.Text = row.Cells[0].Value.ToString().Trim();
            List<ModeloAdicional> lista = modelo.BuscaAdicionais(row.Cells[0].Value.ToString().Trim());
            for (int i = 0; i < lista.Count; i++)
            {
                lbAdicionais.Items.Add(lista[i].Adicionais);
            }
        }
    }
}
