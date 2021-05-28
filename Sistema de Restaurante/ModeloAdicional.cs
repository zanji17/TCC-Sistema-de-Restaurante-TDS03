using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante
{
    class ModeloAdicional
    {
        public string Nome { get; set; }

        public string Adicionais { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public void Criar(string Nome, string Adicionais)
        {
            con.Open();
            string sql = "SELECT IdIngrediente FROM Ingredientes WHERE nome = '" + Adicionais + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int Id = (int)dr["IdIngrediente"];
                con.Close();
                con.Open();
                string sql2 = "INSERT INTO ModeloAdicional(nome, IdIngrediente) VALUES('" + Nome + "', '" + Id + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Deletar(string Nome)
        {
            con.Open();
            string sql = "DELETE * FROM ModeloAdicional WHERE nome = '" + Nome + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<ModeloAdicional> listarModelos()
        {
            List<ModeloAdicional> lista = new List<ModeloAdicional>();
            con.Open();
            string sql = "SELECT DISTINCT nome FROM ModeloAdicional";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                con.Close();
                ModeloAdicional modelo = new ModeloAdicional();
                modelo.Nome = dt.Rows[i]["nome"].ToString().Trim();

                con.Open();
                string sql2 = "SELECT Ingredientes.nome FROM ModeloAdicional INNER JOIN Ingredientes ON ModeloAdicional.IdIngrediente = Ingredientes.IdIngrediente WHERE ModeloAdicional.nome = @nome ORDER BY Ingredientes.nome";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = dt.Rows[i]["nome"].ToString().Trim();
                SqlDataReader dr = cmd2.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    if(count > 0)
                    {
                        modelo.Adicionais += ", ";
                    }
                    modelo.Adicionais += dr["nome"].ToString().Trim();
                }
                lista.Add(modelo);
            }
            con.Close();
            return lista;
        }

        public List<ModeloAdicional> BuscaAdicionais(string Nome)
        {
            con.Open();
            List<ModeloAdicional> lista = new List<ModeloAdicional>();
            string sql = "SELECT Ingredientes.nome FROM ModeloAdicional INNER JOIN Ingredientes ON ModeloAdicional.IdIngrediente = Ingredientes.IdIngrediente WHERE ModeloAdicional.nome = '" + Nome + "' ORDER BY Ingredientes.nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ModeloAdicional modelo = new ModeloAdicional();
                modelo.Adicionais = dr["nome"].ToString().Trim();
                lista.Add(modelo);
            }
            con.Close();
            return lista;
        }

        public List<ModeloAdicional> listarAdicionais()
        {
            List<ModeloAdicional> lista = new List<ModeloAdicional>();
            con.Open();
            string sql = "SELECT nome FROM Ingredientes WHERE Adicional = 'S'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ModeloAdicional modelo = new ModeloAdicional();
                modelo.Adicionais = dr["nome"].ToString().Trim();
                lista.Add(modelo);
            }
            con.Close();
            return (lista);
        }
    }
}
