using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    class Ingrediente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string Adicional { get; set; }

        public string Detalhes { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        //Ingredientes
        public List<Ingrediente> listarIngred()
        {
            List<Ingrediente> listaIngred = new List<Ingrediente>();
            con.Open();
            string sql = "SELECT * FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ingrediente ingred = new Ingrediente();
                ingred.Id = (int)dr["IdIngrediente"];
                ingred.Nome = dr["nome"].ToString().Trim();
                ingred.Tipo = dr["Tipo"].ToString().Trim();
                ingred.Adicional = dr["Adicional"].ToString().Trim();
                ingred.Detalhes = dr["detalhe"].ToString().Trim();
                listaIngred.Add(ingred);
            }
            return listaIngred;
        }

        public void Inserir(string Nome, string Tipo, string Adicional, string Detalhes)
        {
            con.Open();
            string sql = "SELECT nome FROM Ingredientes WHERE nome = '" + Nome + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                con.Close();
                con.Open();
                string sql2 = "INSERT INTO Ingredientes( nome, Tipo, Adicional, detalhe) VALUES('" + Nome + "','" + Tipo + "', '" + Adicional + "','"+Detalhes+"')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Este nome de ingrediente já está sendo usado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public void Atualizar(string Nome, string Tipo, string Adicional, string Detalhes, int Id)
        {
            con.Open();
            string sql = "SELECT IdIngrediente FROM Ingredientes WHERE nome = '" + Nome + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                con.Close();
                con.Open();
                string sql2 = "UPDATE Ingredientes SET nome = '" + Nome + "', Tipo = '" + Tipo + "', Adicional = '" + Adicional + "', detalhe = '"+Detalhes+ "' WHERE IdIngrediente = '" + Id + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                if ((int)dr["IdIngrediente"] == Id)
                {
                    con.Close();
                    con.Open();
                    string sql2 = "UPDATE Ingredientes SET nome = '" + Nome + "', Tipo = '" + Tipo + "', Adicional = '" + Adicional + "', detalhe = '" + Detalhes + "' WHERE IdIngrediente = '" + Id + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Este nome de ingrediente já está sendo usado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        public void Apagar(int Id)
        {
            con.Open();
            string sql = "DELETE FROM Ingredientes WHERE IdIngrediente = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //----------------------------------------------------------------------------------

        //Registrar Prato
        public List<Ingrediente> Pesquisar(string nome)
        {
            List<Ingrediente> lista = new List<Ingrediente>();
            con.Open();
            string sql = "SELECT nome FROM Ingredientes WHERE nome LIKE '"+ nome + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ingrediente ingred = new Ingrediente();
                ingred.Nome = dr["nome"].ToString().Trim();
                lista.Add(ingred);
            }
            con.Close();
            return lista;
        }
        //-----------------------------------------------------------
    }
}
