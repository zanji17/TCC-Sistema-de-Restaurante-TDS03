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
    public partial class FormRegistrarPrato : Form
    {
        public int IdPP { get; set; }
        
        public int IdPedido { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormRegistrarPrato(int Id)
        {
            IdPedido = Id;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistrarPrato_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT nome FROM PratosProdutos";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbPP.Items.Add(dr["nome"].ToString().Trim());
            }
            con.Close();
            cbPP.SelectedIndex = 0;
        }

        private void cbPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAdicional.Items.Clear();
            clbRetirar.Items.Clear();
            con.Open();
            string sql2 = "SELECT tipo, IdPratoProduto FROM PratosProdutos WHERE nome = @nome";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = cbPP.SelectedItem.ToString();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            txtTipo.Text = dr2["tipo"].ToString().Trim();
            IdPP = (int)dr2["IdPratoProduto"];
            con.Close();

            con.Open();
            string sql3 = "SELECT nome FROM Ingredientes WHERE adicional = 'S'";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                clbAdicional.Items.Add(dr3["nome"].ToString().Trim());
            }
            con.Close();

            con.Open();
            string sql4 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN PratosProdutosIngredientes on Ingredientes.IdIngrediente = PratosProdutosIngredientes.IdIngredientes INNER JOIN PratosProdutos on PratosProdutosIngredientes.IdPratosProdutos = PratosProdutos.IdPratoProduto WHERE PratosProdutos.IdPratoProduto = '" + IdPP + "'";
            SqlCommand cmd4 = new SqlCommand(sql4, con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                clbRetirar.Items.Add(dr4["nome"]).ToString().Trim();
            }
            con.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            registro.InserirPrato(IdPedido, cbPP.SelectedItem.ToString(), (int)nQuantidade.Value, txtOBS.Text);
            if(clbAdicional.CheckedItems.Count > 0)
            {
                for (var i = 0; i < clbAdicional.CheckedItems.Count; i++)
                {
                    registro.AdicionaisRetirados(IdPedido, clbAdicional.CheckedItems[i].ToString(), "Adicional");
                }
            }
            if(clbRetirar.CheckedItems.Count > 0)
            {
                for (var i = 0; i < clbRetirar.CheckedItems.Count; i++)
                {
                    registro.AdicionaisRetirados(IdPedido, clbRetirar.CheckedItems[i].ToString(), "Retirar");
                }
            }
            this.Close();
        }
    }
}
