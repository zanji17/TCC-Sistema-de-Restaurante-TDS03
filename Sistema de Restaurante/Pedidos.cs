using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Restaurante
{
    class Pedidos
    {
        public int IdPedido { get; set; }

        public string Cliente { get; set; }

        public string Mesa { get; set; }

        public int Pessoas { get; set; }

        public string Data { get; set; }

        public int IdAtendente { get; set; }

        public string Atendente { get; set; }

        public string Status { get; set; }

        public string CPF { get; set; }

        public int NumeroPedidos { get; set; }

        public int NumeroPratos { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        //Home Atendente
        public void LocalizaAtendente(int Id)
        {
            con.Open();
            string sql = "SELECT IdAtendente FROM Atendentes WHERE IdAcesso = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                IdAtendente = (int)dr["IdAtendente"];
                con.Close();
            }
            con.Close();
        }

        public void CriarPedido(int IdAtendente, string Cliente, string Mesa, int Pessoas)
        {
            con.Open();
            string sql = "SELECT * FROM Pedidos WHERE nome = '" + Cliente + "' AND mesa = '" + Mesa + "' AND status = 'Aberto'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                con.Close();
                con.Open();
                string sql1 = "INSERT INTO Pedidos(nome, mesa, quantidade, IdAtendente, status, data) VALUES('" + Cliente + "','" + Mesa + "','" + Pessoas + "','" + IdAtendente + "', 'Aberto', @data)";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = DateTime.Now;
                cmd1.ExecuteNonQuery();

                string sql2 = "SELECT IdPedido FROM Pedidos WHERE IdAtendente = '" + IdAtendente + "' AND mesa = '" + Mesa + "' AND nome = '" + Cliente + "' AND status= 'Aberto'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    IdPedido = (int)dr1["IdPedido"];
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Esse Cliente Possui um Pedido em Aberto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                con.Close();
            }
        }
        
        public List<Pedidos> MeusPedidos(int IdAtendente)
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT * FROM Pedidos WHERE IdAtendente = '" + IdAtendente + "' AND status = 'Aberto' ORDER BY mesa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["nome"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                pedido.IdPedido = (int)dr["IdPedido"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }

        public List<Pedidos> PedidosGeral(int Id)
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Pedidos.IdAtendente, Pedidos.IdPedido FROM Pedidos LEFT JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente WHERE Pedidos.IdAtendente != '" + Id + "' AND status = 'Aberto' ORDER BY mesa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                if ((int)dr["IdAtendente"] == 0)
                {
                    pedido.Atendente = "Gerente";
                }
                else
                {
                    pedido.Atendente = dr["atendente"].ToString().Trim();
                }
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }
        //------------------------------------------------------------------------------

        //Home Caixa
        public List<Pedidos> PedidosCaixa()
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Pedidos.IdAtendente, Pedidos.IdPedido FROM Pedidos LEFT JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente WHERE status = 'Aberto' ORDER BY mesa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                if ((int)dr["IdAtendente"] == 0)
                {
                    pedido.Atendente = "Gerente";
                }
                else
                {
                    pedido.Atendente = dr["atendente"].ToString().Trim();
                }
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }

        //Relatório de Pedidos
        public List<Pedidos> PedidosRelatorio(string datainicial, string datafinal)
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Pedidos.IdPedido, Pedidos.IdAtendente FROM Pedidos LEFT JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente WHERE Pedidos.data >= '"+datainicial+"' AND Pedidos.data <= '"+datafinal+"' ORDER BY data";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                if ((int)dr["IdAtendente"] == 0)
                {
                    pedido.Atendente = "Gerente";
                }
                else
                {
                    pedido.Atendente = dr["atendente"].ToString().Trim();
                }
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }
        //-------------------------------------------------------------------------------

        //Registro Pedido
        public void CancelaPedido(int IdPedido)
        {
            con.Open();
            string sql = "UPDATE Pedidos SET status = 'Cancelado' WHERE IdPedido = '"+IdPedido+"'";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Relatório de Atendimento
        public List<Pedidos> ListarAtendimento(string datainicial, string datafinal)
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT * FROM Atendentes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                con.Close();
                Pedidos pedido = new Pedidos();
                pedido.IdAtendente = (int)dt.Rows[i]["IdAtendente"];
                pedido.Atendente = dt.Rows[i]["nome"].ToString().Trim();
                pedido.CPF = dt.Rows[i]["cpf"].ToString().Trim();
                con.Open();
                string sql2 = "SELECT COUNT(*) as pedidos FROM Pedidos WHERE IdAtendente = '" + pedido.IdAtendente + "' AND data>='"+datainicial+"' AND data<='"+datafinal+"'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    pedido.NumeroPedidos = (int)dr["pedidos"];
                    con.Close();
                    con.Open();
                    string sql3 = "SELECT COUNT(*) as registro FROM PedidosPratosProdutos INNER JOIN Pedidos ON PedidosPratosProdutos.IdPedido = Pedidos.IdPedido WHERE PedidosPratosProdutos.IdAtendente = '" + pedido.IdAtendente + "' AND Pedidos.data>='" + datainicial + "' AND Pedidos.data<='" + datafinal + "'";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    SqlDataReader dr2 = cmd3.ExecuteReader();
                    if (dr2.Read())
                    {
                        pedido.NumeroPratos = (int)dr2["registro"];
                        con.Close();
                    }
                }
                lista.Add(pedido);
            }
            return lista;
        }

        public List<Pedidos> ListarPedidos(int IdAtendente, string datainicial, string datafinal)
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT * FROM Pedidos WHERE IdAtendente = '" + IdAtendente + "' AND data>='" + datainicial + "' AND data<='" + datafinal + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.Cliente = dr["nome"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Status = dr["status"].ToString().Trim();
                pedido.Data = dr["data"].ToString().Trim();
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }
        //---------------------------------------------------------------------------------------
    }
}
