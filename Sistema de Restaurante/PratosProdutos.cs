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

        public string Adicional { get; set; }

        public string Cozinha { get; set; }

        public string Valor { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        //Pratos e Produtos
        public List<PratosProdutos> listaTiposIngredientes()
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT DISTINCT tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.tipo = dr["tipo"].ToString().Trim();
                lista.Add(PP);
            }
            con.Close();
            return lista;
        }

        public List<PratosProdutos> listaIngredientes()
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
            SqlCommand cmdingred = new SqlCommand(ingred, con);
            SqlDataReader dringred = cmdingred.ExecuteReader();
            while (dringred.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.ingrediente = dringred["nome"].ToString().Trim();
                lista.Add(PP);
            }
            con.Close();
            return lista;
        }

        public List<PratosProdutos> listaIngredientesPorTipo(string tipo)
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT nome FROM Ingredientes WHERE Tipo = '"+tipo+"' ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.ingrediente = dr["nome"].ToString().Trim();
                lista.Add(PP);
            }
            con.Close();
            return lista;
        }

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
                    PP.Cozinha = dt.Rows[i]["cozinha"].ToString().Trim();
                    PP.Valor = dt.Rows[i]["preco"].ToString().Trim();
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
                    cont = 0;
                    con.Close();
                    con.Open();
                    string sql3 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN Adicional ON Ingredientes.IdIngrediente = Adicional.IdIngrediente INNER JOIN PratosProdutos ON Adicional.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE PratosProdutos.IdPratoProduto = '" + PP.Id + "'";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    SqlDataReader dr2 = cmd3.ExecuteReader();
                    PP.Adicional = "";
                    while (dr2.Read())
                    {
                        if (cont > 0)
                        {
                            PP.Adicional += ", ";
                        }
                        PP.Adicional += dr2["nome"].ToString().Trim();
                        cont++;
                    }
                    li.Add(PP);
                }
            }
            con.Close();
            return li;
        }

        public List<PratosProdutos> listaTipoPP()
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT DISTINCT tipo FROM PratosProdutos";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.tipo = dr["tipo"].ToString().Trim();
                lista.Add(PP);
            }
            con.Close();
            return lista;
        }

        public List<PratosProdutos> listaPPIngredientes(int IdPP)
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT Ingredientes.nome, PratosProdutosIngredientes.retiravel FROM PratosProdutos INNER JOIN PratosProdutosIngredientes ON PratosProdutos.IdPratoProduto = PratosProdutosIngredientes.IdPratosProdutos INNER JOIN Ingredientes ON PratosProdutosIngredientes.IdIngredientes = Ingredientes.IdIngrediente WHERE IdPratoProduto = '"+IdPP+"' ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.ingrediente = dr["nome"].ToString().Trim();
                PP.tipo = dr["retiravel"].ToString().Trim();
                lista.Add(PP);
            }
            con.Close();
            return lista;
        }

        public void InserirPrato(string nome, string tipo, string cozinha, string Valor)
        {
            con.Open();
            string sql3 = "SELECT * FROM PratosProdutos WHERE nome='" + nome + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataReader dr2 = cmd3.ExecuteReader(); 
            if (!dr2.Read()) {
                con.Close();
                con.Open();
                string sql = "INSERT INTO PratosProdutos(nome,tipo,cozinha,preco) VALUES ('" + nome + "', '" + tipo + "', '"+cozinha+"', '"+Valor+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                string sql2 = "SELECT IdPratoProduto FROM PratosProdutos WHERE nome='" + nome + "' AND tipo='" + tipo + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                IdPPRetorno = (int)dr["IdPratoProduto"];
                con.Close();
            }
            else
            {
                using (erro er = new erro("Prato ou Produto já Cadastrado!") { })
                {
                    if (DialogResult.OK == er.ShowDialog())
                    {

                    }
                }
                con.Close();
            }
        }

        public void atualizarPrato(string nome, string tipo, int Id, string cozinha, string Valor)
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
                    string sql = "UPDATE PratosProdutos SET nome = '" + nome + "', tipo = '" + tipo + "', cozinha='"+cozinha+"', preco = '"+Valor+"' WHERE IdPratoProduto = '" + Id + "' ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    using (sucesso sc = new sucesso() { })
                    {
                        if (DialogResult.OK == sc.ShowDialog())
                        {

                        }
                    }
                    con.Close();
                }
                else
                {
                    using (erro er = new erro("Prato ou Produto já Cadastrado!") { })
                    {
                        if (DialogResult.OK == er.ShowDialog())
                        {

                        }
                    }
                    con.Close();
                }
            }
            else
            {
                con.Close();
                con.Open();
                string sql = "UPDATE PratosProdutos SET nome = '" + nome + "', tipo = '" + tipo + "', preco = '"+Valor+"' WHERE IdPratoProduto = '" + Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                using (sucesso sc = new sucesso() { })
                {
                    if (DialogResult.OK == sc.ShowDialog())
                    {

                    }
                }
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


        public void PratosIngred(int Id, int IdIng, string retiravel)
        {
            con.Open();
            string sql = "INSERT INTO PratosProdutosIngredientes(IdPratosProdutos,IdIngredientes,retiravel) VALUES ('"+Id+"','"+IdIng+"','"+retiravel+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void PratosAdicional(int IdPP, int IdIng)
        {
            con.Open();
            string sql = "INSERT INTO Adicional(IdPratoProduto, IdIngrediente) VALUES('" + IdPP + "', '" + IdIng + "')";
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
            string sql2 = "DELETE FROM Adicional WHERE IdPratoProduto = '" + Id + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public List<PratosProdutos> CarregaModelos()
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT DISTINCT nome FROM ModeloAdicional";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.ingrediente = dr["nome"].ToString().Trim();
                lista.Add(PP);
            }
            return lista;
        }

        public List<PratosProdutos> listarAdicionais(int id)
        {
            List<PratosProdutos> lista = new List<PratosProdutos>();
            con.Open();
            string sql = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN Adicional ON Ingredientes.IdIngrediente = Adicional.IdIngrediente INNER JOIN PratosProdutos ON Adicional.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE PratosProdutos.IdPratoProduto = '"+id+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PratosProdutos PP = new PratosProdutos();
                PP.ingrediente = dr["nome"].ToString().Trim();
                lista.Add(PP);
            }
            return lista;
        }
        //-----------------------------------------------------------------------------
    }
}
