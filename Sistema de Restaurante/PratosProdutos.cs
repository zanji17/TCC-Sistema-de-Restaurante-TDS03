using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    class PratosProdutos
    {
        public int Id { get; set; }

        public string nome { get; set; }

        public int IdIng { get; set; }

        public int IdIngRetorno { get; set; }

        public int IdPPRetorno { get; set; }

        public string tipo { get; set; }

        public string ingrediente { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public List<PratosProdutos> listaPP()
        {
            con.Open();
            List<PratosProdutos> li = new List<PratosProdutos>();
            string sql = "SELECT * FROM PratosProdutos ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < linhas; i++)
                {
                    PratosProdutos PP = new PratosProdutos();
                    PP.Id = (int)dt.Rows[i]["IdPratoProduto"];
                    PP.nome = dt.Rows[i]["nome"].ToString().Trim();
                    PP.tipo = dt.Rows[i]["tipo"].ToString().Trim();
                    con.Close();
                    con.Open();
                    string sql2 = "SELECT Ingredientes.nome FROM PratosProdutos INNER JOIN PratosProdutosIngredientes ON PratosProdutos.IdPratoProduto = PratosProdutosIngredientes.IdPratosProdutos INNER JOIN Ingredientes ON PratosProdutosIngredientes.IdIngredientes = Ingredientes.IdIngrediente WHERE IdPratoProduto = '" + PP.Id + "' ORDER BY nome";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    SqlDataReader dr = cmd2.ExecuteReader();
                    PP.ingrediente = "";
                    int cont = 0;
                    while (dr.Read())
                    {
                        if (cont > 0)
                        {
                            PP.ingrediente += ", ";
                        }
                        PP.ingrediente += dr["nome"].ToString().Trim();
                        cont++;
                    }
                    li.Add(PP);
                }
            }
            con.Close();
            return li;
        }
        public List<PratosProdutos> filtrartipo()
        {
            List<PratosProdutos> li = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT DISTINCT tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos pp = new PratosProdutos();
                pp.tipo = dr["tipo"].ToString();
                li.Add(pp);
            }
            con.Close();
            return li;
        }

        public void InserirPrato(string nome, string tipo)
        {
            con.Open();
            string sql3 = "SELECT * FROM PratosProdutos WHERE nome='" + nome + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataReader dr2 = cmd3.ExecuteReader(); 
            if (!dr2.Read()) {
                con.Open();
                string sql = "INSERT INTO PratosProdutos(nome,tipo) VALUES ('" + nome + "', '" + tipo + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                string sql2 = "SELECT IdPratoProduto FROM PratosProdutos WHERE nome='" + nome + "' AND tipo='" + tipo + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                IdPPRetorno = (int)dr["IdPratoProduto"];
                con.Close();
            }
        }

        public void atualizarPrato(string nome, string tipo, int Id)
        {
            con.Open();
            string sql1 = "SELECT IdPratoProduto FROM PratosProdutos WHERE nome = '" + nome + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                if ((int) dr["IdPratoProduto"] == Id)
                {
                    con.Close();
                    con.Open();
                    string sql = "UPDATE PratosProdutos SET nome = '" + nome + "', tipo = '" + tipo + "' WHERE IdPratoProduto = '" + Id + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Prato ou Produto já Cadastrado!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    con.Close();
                }
            }
            else
            {
                con.Close();
                con.Open();
                string sql = "UPDATE PratosProdutos SET nome = '" + nome + "', tipo = '" + tipo + "' WHERE IdPratoProduto = '" + Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void apagarPrato(int Id)
        {
            con.Open();
            string sql = "DELETE FROM PratosProdutos WHERE IdPratoProduto = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            string sql1 = "DELETE FROM PratosProdutosIngredientes WHERE IdPratosProdutos = '" + Id + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }


        public void PratosIngred(int Id, int IdIng)
        {
            con.Open();
            string sql = "INSERT INTO PratosProdutosIngredientes(IdPratosProdutos,IdIngredientes) VALUES ('"+Id+"','"+IdIng+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void IdIngred(string nome)
        {
            con.Open();
            string sql = "SELECT IdIngrediente FROM Ingredientes WHERE nome = '" + nome + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                IdIngRetorno = (int)dr["IdIngrediente"];
            }
            con.Close();
        }
        public void RenovarIng(int Id)
        {
            con.Open();
            string sql = "DELETE FROM PratosProdutosIngredientes WHERE IdPratosProdutos = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
