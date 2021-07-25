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
    public partial class pesquisar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public pesquisar()
        {
            InitializeComponent();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
            if (txtPesquisa.Text != null && txtPesquisa.Text != "")
            {
                Ingrediente ingred = new Ingrediente();
                List<Ingrediente> lista = ingred.Pesquisar(txtPesquisa.Text);
                for (int i = 0; i < lista.Count; i++)
                {
                    lbResultado.Items.Add(lista[i].Nome);
                }
            }
        }

        private void lbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT detalhe FROM Ingredientes WHERE nome = @nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = lbResultado.SelectedItem.ToString().Trim();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblDescricao.Text = lbResultado.SelectedItem.ToString().Trim() + ": " + dr["detalhe"].ToString().Trim();
                con.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
