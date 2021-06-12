using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    class Atendente
    {
        public int IdAtendente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int IdAcesso { get; set; }
        public string login { get; set; }
        public string senha { get; set; }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        //Atendente
        public void Inserir(string nome, string cpf, string login, string senha)
        {
            con.Open();
            string sql4 = "SELECT cpf FROM Atendentes WHERE cpf = '"+ cpf +"'";
            SqlCommand cmd4 = new SqlCommand(sql4, con);
            SqlDataReader rd2 = cmd4.ExecuteReader();
            if( !rd2.Read() )
            {
                con.Close();
                con.Open();
                string sql5 = "SELECT login FROM Acessos WHERE login = '"+ Base64.Base64Encode(login) +"'";
                SqlCommand cmd5 = new SqlCommand(sql5, con);
                SqlDataReader rd3 = cmd5.ExecuteReader();
                if ( !rd3.Read())
                {
                    con.Close();
                    string sql = "INSERT INTO Acessos (login,senha,cargo) VALUES ('" + Base64.Base64Encode(login) + "','" + Base64.Base64Encode(senha) + "', 'Atendente')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    string sql2 = "SELECT IdAcesso FROM Acessos WHERE login = '" + Base64.Base64Encode(login) + "' AND senha = '" + Base64.Base64Encode(senha) + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    SqlDataReader rd = cmd2.ExecuteReader();
                    if (rd.Read())
                    {
                        IdAcesso = (int)rd["IdAcesso"];
                        con.Close();
                        con.Open();
                        string sql3 = "INSERT INTO Atendentes(nome, cpf, IdAcesso) VALUES('" + nome + "', '" + cpf + "', '" + IdAcesso + "')";
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        cmd3.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("LOGIN já está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                con.Close();
                MessageBox.Show("CPF já está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Atendente> listaAtendentes()
        {
            List<Atendente> li = new List<Atendente>();
            string sql = "SELECT Atendentes.IdAtendente AS Id, Atendentes.nome,Atendentes.cpf,Acessos.login,Acessos.senha,Acessos.IdAcesso FROM Atendentes INNER JOIN Acessos ON Atendentes.IdAcesso = Acessos.IdAcesso";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Atendente atendentes = new Atendente();
                atendentes.IdAtendente = (int)dr["Id"];
                atendentes.nome = dr["nome"].ToString().Trim();
                atendentes.cpf = dr["cpf"].ToString().Trim();
                atendentes.IdAcesso = (int)dr["IdAcesso"];
                atendentes.login = Base64.Base64Decode(dr["login"].ToString().Trim());
                atendentes.senha = Base64.Base64Decode(dr["senha"].ToString().Trim());
                li.Add(atendentes);
            }
            con.Close();
            return li;
        }


        public void Atualizar(int IdAtendente,int IdAcesso, string nome, string cpf, string login, string senha)
        {
            con.Open();
            string sql4 = "SELECT * FROM Atendentes WHERE cpf = '" + cpf + "'";
            SqlCommand cmd4 = new SqlCommand(sql4, con);
            SqlDataReader rd2 = cmd4.ExecuteReader();
            if (!rd2.Read())
            {
                con.Close();
                con.Open();
                string sql5 = "SELECT * FROM Acessos WHERE login = '" + Base64.Base64Encode(login) + "'";
                SqlCommand cmd5 = new SqlCommand(sql5, con);
                SqlDataReader rd3 = cmd5.ExecuteReader();
                if (!rd3.Read())
                {
                    con.Close();
                    string sql = "UPDATE Atendentes SET nome = '" + nome + "', cpf = '" + cpf + "' WHERE IdAtendente = '" + IdAtendente + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(login) + "', senha = '" + Base64.Base64Encode(senha) + "' WHERE IdAcesso = '" + IdAcesso + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    if(IdAcesso == (int)rd3["IdAcesso"])
                    {
                        con.Close();
                        string sql = "UPDATE Atendentes SET nome = '" + nome + "', cpf = '" + cpf + "' WHERE IdAtendente = '" + IdAtendente + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(login) + "', senha = '" + Base64.Base64Encode(senha) + "' WHERE IdAcesso = '" + IdAcesso + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("LOGIN já está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (IdAtendente == (int)rd2["IdAtendente"])
                {
                    con.Close();
                    con.Open();
                    string sql5 = "SELECT * FROM Acessos WHERE login = '" + Base64.Base64Encode(login) + "'";
                    SqlCommand cmd5 = new SqlCommand(sql5, con);
                    SqlDataReader rd3 = cmd5.ExecuteReader();
                    if (!rd3.Read())
                    {
                        con.Close();
                        string sql = "UPDATE Atendentes SET nome = '" + nome + "', cpf = '" + cpf + "' WHERE IdAtendente = '" + IdAtendente + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(login) + "', senha = '" + Base64.Base64Encode(senha) + "' WHERE IdAcesso = '" + IdAcesso + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        if (IdAcesso == (int)rd3["IdAcesso"])
                        {
                            con.Close();
                            string sql = "UPDATE Atendentes SET nome = '" + nome + "', cpf = '" + cpf + "' WHERE IdAtendente = '" + IdAtendente + "'";
                            con.Open();
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            string sql2 = "UPDATE Acessos SET login = '" + Base64.Base64Encode(login) + "', senha = '" + Base64.Base64Encode(senha) + "' WHERE IdAcesso = '" + IdAcesso + "'";
                            SqlCommand cmd2 = new SqlCommand(sql2, con);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("LOGIN já está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("CPF já está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }


        public void Excluir(int IdAtendente, int IdAcesso)
        {
            string sql = "DELETE FROM Atendentes WHERE IdAtendente = '" + IdAtendente + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            string sql2 = "DELETE FROM Acessos WHERE IdAcesso = '" + IdAtendente + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        //---------------------------------------------------------------------
    }
}
