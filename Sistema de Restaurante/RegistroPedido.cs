using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Restaurante
{
    class RegistroPedido
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public string Mesa { get; set; }

        public string Cliente { get; set; }

        public int Quantidade { get; set; }

        public string PratoProduto { get; set; }

        public string Adicional { get; set; }

        public string Retirar { get; set; }

        public string OBS { get; set; }

        public string Data { get; set; }

        public string Atendente { get; set; }

        public string Status { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public List<RegistroPedido> listaConfirmados()
        {
            List<RegistroPedido> lista = new List<RegistroPedido>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, IdPedidoPratoProduto, PratosProdutos.nome as prato, PedidosPratosProdutos.quantidade, obs, PedidosPratosProdutos.data, PedidosPratosProdutos.status, PedidosPratosProdutos.status, PedidosPratosProdutos.IdAtendente, Pedidos.IdPedido FROM Pedidos INNER JOIN PedidosPratosProdutos ON Pedidos.IdPedido = PedidosPratosProdutos.IdPedido INNER JOIN PratosProdutos ON PedidosPratosProdutos.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE PedidosPratosProdutos.status = 'Confirmado' AND PratosProdutos.tipo != 'Bebida' AND PratosProdutos.tipo != 'bebida' ORDER BY data";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linha = dt.Rows.Count; 
            for (int i = 0; i < linha; i++)
            {
                con.Close();
                RegistroPedido registro = new RegistroPedido();
                registro.Cliente = dt.Rows[i]["cliente"].ToString().Trim();
                registro.Mesa = dt.Rows[i]["mesa"].ToString().Trim();
                registro.PratoProduto = dt.Rows[i]["prato"].ToString().Trim();
                registro.Quantidade = (int)dt.Rows[i]["quantidade"];
                registro.OBS = dt.Rows[i]["OBS"].ToString().Trim();
                registro.Id = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                DateTime hora = (DateTime)dt.Rows[i]["data"];
                registro.Data = hora.ToString("HH:mm:ss");
                registro.Status = dt.Rows[i]["status"].ToString().Trim();
                registro.IdPedido = (int)dt.Rows[i]["IdPedido"];
                con.Open();
                string sql2 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN AdicionaisRetirados ON Ingredientes.IdIngrediente = AdicionaisRetirados.IdIngredientes INNER JOIN PedidosPratosProdutos ON AdicionaisRetirados.IdPedidosPratosProdutos = PedidosPratosProdutos.IdPedidoPratoProduto WHERE AdicionaisRetirados.Status = 'Adicional' AND PedidosPratosProdutos.IdPedidoPratoProduto=@Id";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                SqlDataReader dr = cmd2.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    if(count > 1)
                    {
                        registro.Adicional += ", ";
                    }
                    registro.Adicional += dr["nome"].ToString().Trim();
                }
                con.Close();

                con.Open();
                string sql3 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN AdicionaisRetirados ON Ingredientes.IdIngrediente = AdicionaisRetirados.IdIngredientes INNER JOIN PedidosPratosProdutos ON AdicionaisRetirados.IdPedidosPratosProdutos = PedidosPratosProdutos.IdPedidoPratoProduto WHERE AdicionaisRetirados.Status = 'Retirar' AND PedidosPratosProdutos.IdPedidoPratoProduto=@Id";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                SqlDataReader dr2 = cmd3.ExecuteReader();
                count = 0;
                while (dr2.Read())
                {
                    if (count > 1)
                    {
                        registro.Retirar += ", ";
                    }
                    registro.Retirar += dr["nome"].ToString().Trim();
                }
                con.Close();

                con.Open();
                string sql4 = "SELECT nome FROM Atendentes WHERE IdAtendente = @Id";
                SqlCommand cmd4 = new SqlCommand(sql4, con);
                cmd4.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = dt.Rows[i]["IdAtendente"];
                SqlDataReader dr3 = cmd4.ExecuteReader();
                if (dr3.Read())
                {
                    registro.Atendente = dr3["nome"].ToString().Trim();
                    con.Close();
                }
                con.Close();
                lista.Add(registro);
            }
            con.Close();
            return lista;
        }

        public List<RegistroPedido> listaPratos(int Id)
        {
            List<RegistroPedido> lista = new List<RegistroPedido>();
            con.Open();
            string sql = "SELECT IdPedidoPratoProduto, PratosProdutos.nome, PedidosPratosProdutos.quantidade, obs, PedidosPratosProdutos.data, PedidosPratosProdutos.status, PedidosPratosProdutos.status, PedidosPratosProdutos.IdAtendente FROM Pedidos INNER JOIN PedidosPratosProdutos ON Pedidos.IdPedido = PedidosPratosProdutos.IdPedido INNER JOIN PratosProdutos ON PedidosPratosProdutos.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE Pedidos.IdPedido = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linha = dt.Rows.Count;
            for (int i = 0; i < linha; i++)
            {
                con.Close();
                RegistroPedido registro = new RegistroPedido();
                registro.PratoProduto = dt.Rows[i]["nome"].ToString().Trim();
                registro.Quantidade = (int)dt.Rows[i]["quantidade"];
                registro.OBS = dt.Rows[i]["OBS"].ToString().Trim();
                registro.Id = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                if(dt.Rows[i]["data"] != null && dt.Rows[i]["data"].ToString() != "")
                {
                    DateTime hora = (DateTime)dt.Rows[i]["data"];
                    registro.Data = hora.ToString("HH:mm:ss");
                }
                registro.Status = dt.Rows[i]["status"].ToString().Trim();
                con.Open();
                string sql2 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN AdicionaisRetirados ON Ingredientes.IdIngrediente = AdicionaisRetirados.IdIngredientes INNER JOIN PedidosPratosProdutos ON AdicionaisRetirados.IdPedidosPratosProdutos = PedidosPratosProdutos.IdPedidoPratoProduto WHERE AdicionaisRetirados.Status = 'Adicional' AND PedidosPratosProdutos.IdPedidoPratoProduto=@Id";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                SqlDataReader dr = cmd2.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    if (count > 1)
                    {
                        registro.Adicional += ", ";
                    }
                    registro.Adicional += dr["nome"].ToString().Trim();
                }
                con.Close();

                con.Open();
                string sql3 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN AdicionaisRetirados ON Ingredientes.IdIngrediente = AdicionaisRetirados.IdIngredientes INNER JOIN PedidosPratosProdutos ON AdicionaisRetirados.IdPedidosPratosProdutos = PedidosPratosProdutos.IdPedidoPratoProduto WHERE AdicionaisRetirados.Status = 'Retirar' AND PedidosPratosProdutos.IdPedidoPratoProduto=@Id";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = (int)dt.Rows[i]["IdPedidoPratoProduto"];
                SqlDataReader dr2 = cmd3.ExecuteReader();
                count = 0;
                while (dr2.Read())
                {
                    if (count > 1)
                    {
                        registro.Retirar += ", ";
                    }
                    registro.Retirar += dr["nome"].ToString().Trim();
                }
                con.Close();

                con.Open();
                string sql4 = "SELECT nome FROM Atendentes WHERE IdAtendente = @Id";
                SqlCommand cmd4 = new SqlCommand(sql4, con);
                cmd4.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = dt.Rows[i]["IdAtendente"];
                SqlDataReader dr3 = cmd4.ExecuteReader();
                if (dr3.Read())
                {
                    registro.Atendente = dr3["nome"].ToString().Trim();
                    con.Close();
                }
                con.Close();
                lista.Add(registro);
            }
            con.Close();
            return lista;
        }


        public void Localizar(int Id)
        {
            con.Open();
            string sql = "SELECT mesa, nome FROM Pedidos WHERE IdPedido = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Mesa = dr["mesa"].ToString().Trim();
                Cliente = dr["nome"].ToString().Trim();
                con.Close();
            }
            con.Close();
        }

        public void InserirPrato(int Pedido, string PratoProduto, int Quantidade, string OBS)
        {
            con.Open();
            string sql = "SELECT IdPratoProduto FROM PratosProdutos WHERE nome = '" + PratoProduto + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int PP = (int)dr["IdPratoProduto"];
                con.Close();
                con.Open();
                string sql2 = "INSERT INTO PedidosPratosProdutos(IdPedido,IdPratoProduto, quantidade, obs) VALUES('" + Pedido + "', '" + PP + "', '" + Quantidade + "', '" + OBS + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
        }

        public void AdicionaisRetirados(int IdPedido, string ingrediente, string status)
        {
            con.Open();
            string sql = "SELECT IdIngrediente FROM Ingredientes WHERE nome = '" + ingrediente + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int IdIngred = (int)dr["IdIngrediente"];
                con.Close();
                con.Open();
                string sql1 = "SELECT Max(IdPedidoPratoProduto) FROM PedidosPratosProdutos WHERE IdPedido = '" + IdPedido + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    int id = (int)dr1["IdPedidoPratoProduto"];
                    con.Close();
                    con.Open();
                    string sql2 = "INSERT INTO AdicionaisRetirados(IdPedidosPratosProdutos, status, IdIngredientes) VALUES('" + id + "','" + status + "','" + IdIngred + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void Confirmar(int IdPPP, int IdAT)
        {
            con.Open();
            string sql = "UPDATE PedidosPratosProdutos SET IdAtendente = '" + IdAT + "', status = 'Confirmado', data = @data WHERE IdPedidoPratoProduto = '" + IdPPP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Servido(int IdPPP)
        {
            con.Open();
            string sql = "UPDATE PedidosPratosProdutos SET status = 'Servido' WHERE IdPedidoPratoProduto = '" + IdPPP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
