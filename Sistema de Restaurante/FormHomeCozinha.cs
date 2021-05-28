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
            string[] arrayPR = new string[clbPR.CheckedItems.Count];
            List<RegistroPedido> lista = registro.listaConfirmados(arrayPR);
            dgvPratoConfirmado.DataSource = lista;
            List<RegistroPedido> lista2 = registro.listaPC();
            dgvPC.DataSource = lista2;
            List<RegistroPedido> lista3 = registro.listarTipos();
            for (int i = 0; i < lista3.Count; i++)
            {
                clbPR.Items.Add(lista3[i].PratoProduto);
            }
            List<RegistroPedido> lista5 = registro.listaPR(arrayPR);
            dgvPR.DataSource = lista5;
        }

        private void clbPR_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            if (e.NewValue == CheckState.Checked)
            {
                string[] arrayPR = new string[clbPR.CheckedItems.Count+1];
                arrayPR[clbPR.CheckedItems.Count] = clbPR.SelectedItem.ToString().Trim();
                for (int i = 0; i < clbPR.CheckedItems.Count; i++)
                {
                    arrayPR[i] = clbPR.CheckedItems[i].ToString().Trim();
                }
                List<RegistroPedido> lista = registro.listaConfirmados(arrayPR);
                dgvPratoConfirmado.DataSource = lista;
                List<RegistroPedido> lista2 = registro.listaPR(arrayPR);
                dgvPR.DataSource = lista2;
            }
            else
            {
                string[] arrayPR = new string[clbPR.CheckedItems.Count-1];
                for (int i = 0; i < clbPR.CheckedItems.Count; i++)
                {
                    if(clbPR.CheckedItems[i].ToString().Trim() != clbPR.SelectedItem.ToString().Trim())
                    {
                        for (int j = 0; j < clbPR.CheckedItems.Count-1; j++)
                        {
                            arrayPR[j] = clbPR.CheckedItems[i].ToString().Trim();
                        }
                    }
                }
                List<RegistroPedido> lista = registro.listaConfirmados(arrayPR);
                dgvPratoConfirmado.DataSource = lista;
                List<RegistroPedido> lista2 = registro.listaPR(arrayPR);
                dgvPR.DataSource = lista2;
            }
        }
    }
}
