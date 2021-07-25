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
    public partial class FormHomeCozinha : Form
    {
        public string cargo { get; set; }

        public FormHomeCozinha(string tipo)
        {
            cargo = tipo;
            InitializeComponent();
        }

        public void AtualizaAuto()
        {
            while (true)
            {
                Thread.Sleep(1000);
                string resposta = Atualizar.CountCozinha(dgvPratoConfirmado.Rows.Count + dgvPR.Rows.Count);
                if (resposta == "sim")
                {
                    AtualizarDGV();
                }
            }
        }

        private void FormHomeCozinha_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(AtualizaAuto));
            RegistroPedido registro = new RegistroPedido();
            List<RegistroPedido> lista3 = registro.listarTipos();
            for (int i = 0; i < lista3.Count; i++)
            {
                clbPR.Items.Add(lista3[i].PratoProduto);
            }
            AtualizarDGV();
            t.Start();
        }

        private void clbPR_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            if (e.NewValue == CheckState.Checked)
            {
                string[] arrayPR = new string[clbPR.CheckedItems.Count + 1];
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
                string[] arrayPR = new string[clbPR.CheckedItems.Count - 1];
                for (int i = 0; i < clbPR.CheckedItems.Count; i++)
                {
                    if (clbPR.CheckedItems[i].ToString().Trim() != clbPR.SelectedItem.ToString().Trim())
                    {
                        for (int j = 0; j < clbPR.CheckedItems.Count - 1; j++)
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

        public void AtualizarDGV()
        {
            RegistroPedido registro = new RegistroPedido();
            string[] arrayPR = new string[clbPR.CheckedItems.Count];
            for (int i = 0; i < clbPR.CheckedItems.Count; i++)
            {
                arrayPR[i] = clbPR.CheckedItems[i].ToString();
            }
            List<RegistroPedido> lista = registro.listaConfirmados(arrayPR);
            if (dgvPratoConfirmado.InvokeRequired)
            {
                dgvPratoConfirmado.Invoke((MethodInvoker)delegate
                {
                    dgvPratoConfirmado.DataSource = lista;
                    dgvPratoConfirmado.Columns.Remove("IdPedido");
                    dgvPratoConfirmado.Columns.Remove("Data");
                    dgvPratoConfirmado.Columns.Remove("Status");
                    dgvPratoConfirmado.Columns.Remove("Cliente");
                    dgvPratoConfirmado.Columns[0].Width = 40;
                    dgvPratoConfirmado.Columns[1].Width = 60;
                    dgvPratoConfirmado.Columns[2].HeaderText = "Qnt";
                    dgvPratoConfirmado.Columns[2].Width = 35;
                    dgvPratoConfirmado.Columns[3].Width = 100;
                });
            }
            List<RegistroPedido> lista2 = registro.listaPC();
            if (dgvPC.InvokeRequired)
            {
                dgvPC.Invoke((MethodInvoker)delegate
                {
                    dgvPC.DataSource = lista2;
                    dgvPC.Columns.Remove("IdPedido");
                    dgvPC.Columns.Remove("Data");
                    dgvPC.Columns.Remove("Status");
                    dgvPC.Columns.Remove("Cliente");
                    dgvPC.Columns[0].Width = 40;
                    dgvPC.Columns[1].Width = 60;
                    dgvPC.Columns[2].HeaderText = "Qnt";
                    dgvPC.Columns[2].Width = 35;
                    dgvPC.Columns[3].Width = 100;
                });
            }
            List<RegistroPedido> lista5 = registro.listaPR(arrayPR);
            if (dgvPR.InvokeRequired)
            {
                dgvPR.Invoke((MethodInvoker)delegate
                {
                    dgvPR.DataSource = lista5;
                    dgvPR.Columns.Remove("IdPedido");
                    dgvPR.Columns.Remove("Data");
                    dgvPR.Columns.Remove("Status");
                    dgvPR.Columns.Remove("Cliente");
                    dgvPR.Columns[0].Width = 40;
                    dgvPR.Columns[1].Width = 60;
                    dgvPR.Columns[2].HeaderText = "Qnt";
                    dgvPR.Columns[2].Width = 35;
                    dgvPR.Columns[3].Width = 100;
                });
            }
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHomeCozinha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cargo == "Cozinha")
            {
                Application.Exit();
            }
        }
    }
}
