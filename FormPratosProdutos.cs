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
    public partial class FormPratosProdutos : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gusta\\OneDrive\\Documentos\\TCC 2021\\Restaurante\\Restaurante.mdf;Integrated Security=True");
        public FormPratosProdutos()
        {
            InitializeComponent();
        }

        private void FormPratosProdutos_Load(object sender, EventArgs e)
        {
            con.Open();
            string ctg = "SELECT DISTINCT Tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(ctg, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < linhas; i++)
                {
                    clbCategoria.Items.Add(dt.Rows[i]["Tipo"].ToString());
                }
            }
            con.Close();
            con.Open();
            string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
            SqlCommand cmdingred = new SqlCommand(ingred, con);
            SqlDataAdapter daingred = new SqlDataAdapter(cmdingred);
            DataTable dtingred = new DataTable();
            daingred.Fill(dtingred);
            int linhasingred = dtingred.Rows.Count;
            if (dtingred.Rows.Count > 0)
            {
                for (int i = 0; i < linhasingred; i++)
                {
                    clbIngredientes.Items.Add(dtingred.Rows[i]["nome"].ToString());
                }
            }
            con.Close();
        }

        private void clbCategoria_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            clbIngredientes.Items.Clear();
            if (e.NewValue != CheckState.Unchecked)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbCategoria.Items.Count; i++)
                    {
                        if (i != e.Index)
                            clbCategoria.SetItemChecked(i, false);
                    }
                }
                clbIngredientes.Items.Clear();
                con.Open();
                string tipo = "SELECT nome FROM Ingredientes WHERE Tipo = @tipo ORDER BY nome";
                SqlCommand cmd = new SqlCommand(tipo, con);
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = clbCategoria.SelectedItem.ToString();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int linhas = dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < linhas; i++)
                    {
                        clbIngredientes.Items.Add(dt.Rows[i]["nome"].ToString());
                        foreach (object ingrediente in lbIngredientes.Items)
                        {
                            if(dt.Rows[i]["nome"].ToString() == ingrediente.ToString())
                            {
                                clbIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                con.Close();
            }
            else
            {
                con.Open();
                string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
                SqlCommand cmd2 = new SqlCommand(ingred, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                int linhas2 = dt2.Rows.Count;
                if (dt2.Rows.Count > 0)
                {
                    for (int i = 0; i < linhas2; i++)
                    {
                        clbIngredientes.Items.Add(dt2.Rows[i]["nome"].ToString());
                        foreach (object ingrediente in lbIngredientes.Items)
                        {
                            if (dt2.Rows[i]["nome"].ToString() == ingrediente.ToString())
                            {
                                clbIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void clbIngredientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                var repetido = false;
                foreach(object o1 in lbIngredientes.Items)
                {
                    if(clbIngredientes.SelectedItem == o1)
                    {
                        repetido = true;
                    }
                }
                if(repetido == false && clbIngredientes.SelectedItem != null)
                {
                    lbIngredientes.Items.Add(clbIngredientes.SelectedItem);
                }
            }
            if(e.NewValue == CheckState.Unchecked)
            {
                lbIngredientes.Items.Remove(clbIngredientes.SelectedItem);
            }    
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO PratosProdutos(nome,tipo) VALUES (@nome, @tipo)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = txtTipo.Text.Trim();
            cmd.ExecuteNonQuery();
            
            string sql2 = "SELECT IdPratoProduto FROM PratosProdutos WHERE nome=@nome AND tipo=@tipo";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
            cmd2.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = txtTipo.Text.Trim();
            SqlDataReader dr = cmd2.ExecuteReader();
            dr.Read();
            int IdPP = (int)dr["IdPratoProduto"];
            PratosProdutos pratosprodutos = new PratosProdutos();
            foreach (var nomeing in lbIngredientes.Items)
            {
                pratosprodutos.IdIngred(nomeing.ToString());
                pratosprodutos.PratosIngred(IdPP, pratosprodutos.IdIngRetorno);
            }
            MessageBox.Show("Prato ou Produto Cadastrado com Sucesso!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            lbIngredientes.Items.Clear();
            con.Close();
        }
    }
}
