using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurante
{
    class PratosProdutos
    {
        public int IdPP { get; set; }

        public int IdIng { get; set; }

        public string nome { get; set; }

        public int IdIngRetorno { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gusta\\OneDrive\\Documentos\\TCC 2021\\Restaurante\\Restaurante.mdf;Integrated Security=True");
        
        public void PratosIngred(int IdPP, int IdIng)
        {
            con.Open();
            string sql = "INSERT INTO PratosProdutosIngredientes(IdPratosProdutos,IdIngredientes) VALUES ('"+IdPP+"','"+IdIng+"')";
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
    }
}
