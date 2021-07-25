using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class FormModeloAdicional : Form
    {
        public string nome { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormModeloAdicional()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ModeloAdicional modelo = new ModeloAdicional();
            con.Open();
            string sql = "SELECT * FROM ModeloAdicional WHERE nome = @nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                for (int i = 0; i < lbAdicionais.Items.Count; i++)
                {
                    modelo.Criar(txtNome.Text, lbAdicionais.Items[i].ToString().Trim());
                }
                con.Close();
                atualizar();
            }
            else
            {
                MessageBox.Show("Nome de Modelo já em Uso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (nome != null && nome != "")
            {
                ModeloAdicional modelo = new ModeloAdicional();
                modelo.Deletar(nome);
                for (int i = 0; i < lbAdicionais.Items.Count; i++)
                {
                    modelo.Criar(txtNome.Text, lbAdicionais.Items[i].ToString().Trim());
                }
                atualizar();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ModeloAdicional modelo = new ModeloAdicional();
            modelo.Deletar(nome);
            atualizar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void FormModeloAdicional_Load(object sender, EventArgs e)
        {
            atualizar();
        }

        private void clbAdicionais_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (clbAdicionais.SelectedItem != null)
                {
                    lbAdicionais.Items.Add(clbAdicionais.SelectedItem);
                }
            }
            else
            {
                lbAdicionais.Items.Remove(clbAdicionais.SelectedItem);
            }
        }

        public void atualizar()
        {
            ModeloAdicional modelo = new ModeloAdicional();
            nome = string.Empty;
            clbAdicionais.Items.Clear();
            lbAdicionais.Items.Clear();
            clbAdicionais.ClearSelected();
            List<ModeloAdicional> lista = modelo.listarModelos();
            dgvModelos.DataSource = lista;
            dgvModelos.Columns[0].Width = 120;
            List<ModeloAdicional> listaAdicional = modelo.listarAdicionais();
            for (int i = 0; i < listaAdicional.Count; i++)
            {
                clbAdicionais.Items.Add(listaAdicional[i].Adicionais);
            }
            txtNome.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbAdicionais.ClearSelected();
            lbAdicionais.Items.Clear();
            for (int i = 0; i < clbAdicionais.Items.Count; i++)
            {
                clbAdicionais.SetItemChecked(i, false);
            }
            ModeloAdicional modelo = new ModeloAdicional();
            DataGridViewRow row = this.dgvModelos.Rows[e.RowIndex];
            txtNome.Text = row.Cells[0].Value.ToString().Trim();
            nome = row.Cells[0].Value.ToString().Trim();
            List<ModeloAdicional> lista = modelo.BuscaAdicionais(row.Cells[0].Value.ToString().Trim());
            for (int i = 0; i < lista.Count; i++)
            {
                lbAdicionais.Items.Add(lista[i].Adicionais);
                for (var j = 0; j < clbAdicionais.Items.Count; j++)
                {
                    if (lista[i].Adicionais == clbAdicionais.Items[j].ToString())
                    {
                        clbAdicionais.SetItemChecked(j, true);
                    }
                }
            }
        }
    }
}
