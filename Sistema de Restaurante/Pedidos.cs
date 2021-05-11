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

        public

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

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
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Atendentes.IdAtendente, Pedidos.IdPedido FROM Pedidos INNER JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente WHERE Pedidos.IdAtendente != '" + Id + "' AND status = 'Aberto' ORDER BY mesa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                pedido.Atendente = dr["atendente"].ToString().Trim();
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }

        public List<Pedidos> PedidosCaixa()
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Atendentes.IdAtendente, Pedidos.IdPedido FROM Pedidos INNER JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente WHERE status = 'Aberto' ORDER BY mesa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                pedido.Atendente = dr["atendente"].ToString().Trim();
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }

        public List<Pedidos> PedidosRelatorio()
        {
            List<Pedidos> lista = new List<Pedidos>();
            con.Open();
            string sql = "SELECT Pedidos.nome as cliente, Pedidos.mesa, Pedidos.quantidade, Pedidos.data, Atendentes.nome as atendente, Pedidos.IdPedido, Atendentes.IdAtendente FROM Pedidos INNER JOIN Atendentes ON Pedidos.IdAtendente = Atendentes.IdAtendente ORDER BY data";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pedidos pedido = new Pedidos();
                pedido.Cliente = dr["cliente"].ToString().Trim();
                pedido.Mesa = dr["mesa"].ToString().Trim();
                pedido.Pessoas = (int)dr["quantidade"];
                pedido.Data = dr["data"].ToString().Trim();
                pedido.Atendente = dr["atendente"].ToString().Trim();
                pedido.IdPedido = (int)dr["IdPedido"];
                pedido.IdAtendente = (int)dr["IdAtendente"];
                lista.Add(pedido);
            }
            con.Close();
            return lista;
        }
    }
}
