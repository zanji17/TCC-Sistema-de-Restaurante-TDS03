using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class FormRegistrarPrato : Form
    {
        public int IdPPP { get; set; }
        public int IdPP { get; set; }
        public int IdPedido { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormRegistrarPrato(int id, int idppp)
        {
            IdPedido = id;
            IdPPP = idppp;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistrarPrato_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql3 = "SELECT DISTINCT tipo FROM PratosProdutos";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            cbTipo.Items.Add("none");
            while (dr3.Read())
            {
                cbTipo.Items.Add(dr3["tipo"].ToString().Trim());
            }
            con.Close();
            cbTipo.SelectedIndex = 0;
            nQuantidade.Value = 1;
            if (IdPPP > 0)
            {
                con.Open();
                string sql2 = "SELECT PratosProdutos.nome, PedidosPratosProdutos.quantidade, PedidosPratosProdutos.obs FROM PedidosPratosProdutos INNER JOIN PratosProdutos ON PedidosPratosProdutos.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE PedidosPratosProdutos.IdPedidoPratoProduto = '" + IdPPP + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    nQuantidade.Value = (int)dr2["quantidade"];
                    txtOBS.Text = dr2["obs"].ToString().Trim();
                    cbPP.SelectedItem = dr2["nome"].ToString().Trim();
                    con.Close();
                }
            }
        }

        private void cbPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAdicional.Items.Clear();
            clbRetirar.Items.Clear();
            con.Close();
            con.Open();
            string sql2 = "SELECT tipo, IdPratoProduto FROM PratosProdutos WHERE nome = @nome";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = cbPP.SelectedItem.ToString();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            IdPP = (int)dr2["IdPratoProduto"];
            con.Close();

            con.Open();
            string sql3 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN Adicional ON Ingredientes.IdIngrediente = Adicional.IdIngrediente INNER JOIN PratosProdutos ON Adicional.IdPratoProduto = PratosProdutos.IdPratoProduto WHERE PratosProdutos.IdPratoProduto = '" + IdPP + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                clbAdicional.Items.Add(dr3["nome"].ToString().Trim());
            }
            con.Close();

            con.Open();
            string sql4 = "SELECT Ingredientes.nome FROM Ingredientes INNER JOIN PratosProdutosIngredientes on Ingredientes.IdIngrediente = PratosProdutosIngredientes.IdIngredientes INNER JOIN PratosProdutos on PratosProdutosIngredientes.IdPratosProdutos = PratosProdutos.IdPratoProduto WHERE PratosProdutos.IdPratoProduto = '" + IdPP + "' AND PratosProdutosIngredientes.retiravel = 'S'";
            SqlCommand cmd4 = new SqlCommand(sql4, con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                clbRetirar.Items.Add(dr4["nome"]).ToString().Trim();
            }
            con.Close();
            if (IdPPP > 0)
            {
                con.Open();
                string sql5 = "SELECT Ingredientes.nome, AdicionaisRetirados.Status FROM Ingredientes INNER JOIN AdicionaisRetirados ON Ingredientes.IdIngrediente = AdicionaisRetirados.IdIngredientes WHERE AdicionaisRetirados.IdPedidosPratosProdutos = '" + IdPPP + "'";
                SqlCommand cmd5 = new SqlCommand(sql5, con);
                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    if (dr5["Status"].ToString().Trim() == "Adicional")
                    {
                        for (int i = 0; i < clbAdicional.Items.Count; i++)
                        {
                            if (clbAdicional.Items[i].ToString().Trim() == dr5["nome"].ToString().Trim())
                            {
                                clbAdicional.SetItemChecked(i, true);
                            }
                        }
                    }
                    else if (dr5["Status"].ToString().Trim() == "Retirar")
                    {
                        for (int i = 0; i < clbRetirar.Items.Count; i++)
                        {
                            if (clbRetirar.Items[i].ToString().Trim() == dr5["nome"].ToString().Trim())
                            {
                                clbRetirar.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            RegistroPedido registro = new RegistroPedido();
            if (nQuantidade.Value > 0)
            {
                if (IdPPP > 0)
                {
                    registro.EditarPrato(cbPP.SelectedItem.ToString(), (int)nQuantidade.Value, txtOBS.Text, IdPPP);
                    registro.DeletarAdicionaisRetirados(IdPPP);
                    if (clbAdicional.CheckedItems.Count > 0)
                    {
                        for (var i = 0; i < clbAdicional.CheckedItems.Count; i++)
                        {
                            registro.AdicionaisRetirados(IdPedido, clbAdicional.CheckedItems[i].ToString(), "Adicional");
                        }
                    }
                    if (clbRetirar.CheckedItems.Count > 0)
                    {
                        for (var i = 0; i < clbRetirar.CheckedItems.Count; i++)
                        {
                            registro.AdicionaisRetirados(IdPedido, clbRetirar.CheckedItems[i].ToString(), "Retirar");
                        }
                    }
                    this.Close();
                }
                else
                {
                    registro.InserirPrato(IdPedido, cbPP.SelectedItem.ToString(), (int)nQuantidade.Value, txtOBS.Text);
                    if (clbAdicional.CheckedItems.Count > 0)
                    {
                        for (var i = 0; i < clbAdicional.CheckedItems.Count; i++)
                        {
                            registro.AdicionaisRetirados(IdPedido, clbAdicional.CheckedItems[i].ToString(), "Adicional");
                        }
                    }
                    if (clbRetirar.CheckedItems.Count > 0)
                    {
                        for (var i = 0; i < clbRetirar.CheckedItems.Count; i++)
                        {
                            registro.AdicionaisRetirados(IdPedido, clbRetirar.CheckedItems[i].ToString(), "Retirar");
                        }
                    }
                    this.Close();
                }
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPP.Items.Clear();
            con.Open();
            string sql = "SELECT nome FROM PratosProdutos";
            if (cbTipo.SelectedItem.ToString() != "none")
            {
                sql += " WHERE tipo=@tipo";
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cbTipo.SelectedItem.ToString() != "none")
            {
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = cbTipo.SelectedItem.ToString();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbPP.Items.Add(dr["nome"].ToString().Trim());
            }
            con.Close();
            cbPP.SelectedIndex = 0;
        }

        private void FormRegistrarPrato_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar p = new pesquisar();
            p.Show();
        }
    }
}
