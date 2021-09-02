using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    class Login
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public void Logar(string login, string senha)
        {
            con.Open();
            string sql = "SELECT * FROM Acessos WHERE login = '" + Base64.Base64Encode(login) + "' AND senha = '" + Base64.Base64Encode(senha) + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = (int)dr["Idacesso"];
                cargo = dr["cargo"].ToString().Trim();
                con.Close();
            }
            else
            {
                using (erro er = new erro("Login ou Senha Incorreto. Tente Novamente!") { })
                {
                    if (DialogResult.OK == er.ShowDialog())
                    {

                    }
                }
                con.Close();
            }
        }
    }
}
