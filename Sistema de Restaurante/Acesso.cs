using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restaurante
{
    class Acesso
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Cargo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        //Acesso
        public List<Acesso> listarAcesso()
        {
            List<Acesso> listaAcesso = new List<Acesso>();
            con.Open();
            string sql = "SELECT * FROM Acessos WHERE cargo != 'Atendente'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Acesso acesso = new Acesso();
                acesso.Id = (int)dr["Idacesso"];
                acesso.Login = Base64.Base64Decode(dr["login"].ToString().Trim());
                acesso.Senha = Base64.Base64Decode(dr["senha"].ToString().Trim());
                acesso.Cargo = dr["cargo"].ToString().Trim();
                listaAcesso.Add(acesso);
            }
            return listaAcesso;
        }

        public void Inserir(string Login, string Senha, string Cargo)
        {
            con.Open();
            string sql = "SELECT login FROM Acessos WHERE login = '"+ Base64.Base64Encode(Login) +"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) 
            {
                con.Close();
                con.Open();
                string sql2 = "INSERT INTO Acessos( login, senha, cargo) VALUES('" + Base64.Base64Encode(Login) + "','" + Base64.Base64Encode(Senha) + "', '" + Cargo + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Este login já está sendo usado!", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                con.Close();
            }
        }
        public void Atualizar(string Login, string Senha, string Cargo, int Id)
        {
            con.Open();
            string sql = "SELECT Idacesso FROM Acessos WHERE login = '" + Base64.Base64Encode(Login) + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                con.Close();
                con.Open();
                string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(Login) + "', senha = '" + Base64.Base64Encode(Senha) + "', cargo = '" + Cargo + "' WHERE Idacesso = '"+Id+"'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                if ((int)dr["Idacesso"] == Id)
                {
                    con.Close();
                    con.Open();
                    string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(Login) + "', senha = '" + Base64.Base64Encode(Senha) + "', cargo = '" + Cargo + "' WHERE Idacesso = '" + Id + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Este login já está sendo usado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }
        public void Apagar(int Id)
        {
            con.Open();
            string sql = "DELETE FROM Acessos WHERE Idacesso = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //------------------------------------------------------------------------
    }
}
