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
    public partial class FormPratosProdutos : Form
    {
        public int IdPP { get; set; }

        public string nome { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gusta\\OneDrive\\Documentos\\TCC 2021\\restaurante-main\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");
        public FormPratosProdutos()
        {
            InitializeComponent();
        }

        private void FormPratosProdutos_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT DISTINCT tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clbCategoria.Items.Add(dr["tipo"].ToString());
            }
            con.Close();
            con.Open();
            string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
            SqlCommand cmdingred = new SqlCommand(ingred, con);
            SqlDataReader dringred = cmdingred.ExecuteReader();
            while (dringred.Read())
            {
                clbIngredientes.Items.Add(dringred["nome"].ToString());   
            }
            con.Close();
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> Pratos = PP.listaPP();
            dgvPratosProdutos.DataSource = Pratos;
            dgvPratosProdutos.Columns.Remove("IdIng");
            dgvPratosProdutos.Columns.Remove("IdIngRetorno");
            dgvPratosProdutos.Columns.Remove("IdPPRetorno");
        }

        private void clbCategoria_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            clbIngredientes.Items.Clear();
            if (e.NewValue != CheckState.Unchecked)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbCategoria.Items.Count; i++)
                    {
                        if (i != e.Index)
                            clbCategoria.SetItemChecked(i, false);
                    }
                }
                clbIngredientes.Items.Clear();
                con.Open();
                string tipo = "SELECT nome FROM Ingredientes WHERE Tipo = @tipo ORDER BY nome";
                SqlCommand cmd = new SqlCommand(tipo, con);
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = clbCategoria.SelectedItem.ToString();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int linhas = dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < linhas; i++)
                    {
                        clbIngredientes.Items.Add(dt.Rows[i]["nome"].ToString());
                        foreach (object ingrediente in lbIngredientes.Items)
                        {
                            if(dt.Rows[i]["nome"].ToString() == ingrediente.ToString())
                            {
                                clbIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                con.Close();
            }
            else
            {
                con.Open();
                string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
                SqlCommand cmd2 = new SqlCommand(ingred, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                int linhas2 = dt2.Rows.Count;
                if (dt2.Rows.Count > 0)
                {
                    for (int i = 0; i < linhas2; i++)
                    {
                        clbIngredientes.Items.Add(dt2.Rows[i]["nome"].ToString());
                        foreach (object ingrediente in lbIngredientes.Items)
                        {
                            if (dt2.Rows[i]["nome"].ToString() == ingrediente.ToString())
                            {
                                clbIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void clbIngredientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clbIngredientes.SelectedItem != null) 
            {
                lbIngredientes.Items.Clear();
                for (int i = 0; i < clbIngredientes.CheckedItems.Count; i++)
                {
                    lbIngredientes.Items.Add(clbIngredientes.CheckedItems[i]);
                }
                lbIngredientes.Items.Add(clbIngredientes.SelectedItem);
            }
            if(e.NewValue == CheckState.Unchecked && clbIngredientes.SelectedItem != null )
            {
                lbIngredientes.Items.Clear();
                for (int i = 0; i < clbIngredientes.CheckedItems.Count; i++)
                {
                    lbIngredientes.Items.Add(clbIngredientes.CheckedItems[i]);
                }
                lbIngredientes.Items.Remove(clbIngredientes.SelectedItem);
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtNome.Text != null)
            {
                PratosProdutos pratosprodutos = new PratosProdutos();
                pratosprodutos.InserirPrato(txtNome.Text.Trim(), txtTipo.Text.Trim());
                if (pratosprodutos.IdPPRetorno != 0)
                {
                    foreach (var nomeing in lbIngredientes.Items)
                    {
                        pratosprodutos.IdIngred(nomeing.ToString());
                        pratosprodutos.PratosIngred(pratosprodutos.IdPPRetorno, pratosprodutos.IdIngRetorno);
                    }
                    MessageBox.Show("Prato ou Produto Cadastrado com Sucesso!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<PratosProdutos> Pratos = pratosprodutos.listaPP();
                    dgvPratosProdutos.DataSource = Pratos;
                    dgvPratosProdutos.Columns.Remove("IdIng");
                    dgvPratosProdutos.Columns.Remove("IdIngRetorno");
                    dgvPratosProdutos.Columns.Remove("IdPPRetorno");
                    for (var i = 0; i < clbIngredientes.Items.Count; i++)
                    {
                        clbIngredientes.SetItemChecked(i, false);
                    }
                    txtNome.Text = string.Empty;
                    txtTipo.Text = string.Empty;
                    lbIngredientes.Items.Clear();
                    con.Close();
                    clbIngredientes.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Prato ou Produto já Cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void dgvPratosProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clbIngredientes.ClearSelected();
            lbIngredientes.Items.Clear();
            for (var i = 0; i < clbCategoria.Items.Count; i++)
            {
                clbCategoria.SetItemChecked(i, false);
            }
            for (var i = 0; i < clbIngredientes.Items.Count; i++)
            {
                clbIngredientes.SetItemChecked(i, false);
            }
            DataGridViewRow row = this.dgvPratosProdutos.Rows[e.RowIndex];
            txtNome.Text = row.Cells[1].Value.ToString().Trim();
            txtTipo.Text = row.Cells[2].Value.ToString().Trim();
            con.Open();
            string sql = "SELECT Ingredientes.nome FROM PratosProdutos INNER JOIN PratosProdutosIngredientes ON PratosProdutos.IdPratoProduto = PratosProdutosIngredientes.IdPratosProdutos INNER JOIN Ingredientes ON PratosProdutosIngredientes.IdIngredientes = Ingredientes.IdIngrediente WHERE IdPratoProduto = @Id ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (var i = 0; i < clbIngredientes.Items.Count; i++)
                {
                    if(clbIngredientes.Items[i].ToString().Trim() == dr["nome"].ToString().Trim())
                    {
                        lbIngredientes.Items.Add(dr["nome"].ToString().Trim());
                        clbIngredientes.SetItemChecked(i, true);
                    }
                }
            }
            con.Close();
            IdPP = Convert.ToInt32(row.Cells[0].Value);
            nome = row.Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNome.Text != null)
            {
                PratosProdutos PP = new PratosProdutos();
                PP.atualizarPrato(txtNome.Text.Trim(), txtTipo.Text.Trim(), IdPP);
                PP.RenovarIng(IdPP);
                foreach (var nomeing in lbIngredientes.Items)
                {
                    PP.IdIngred(nomeing.ToString());
                    PP.PratosIngred(IdPP, PP.IdIngRetorno);
                }
                MessageBox.Show("Prato ou Produto Atualizado com Sucesso!!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<PratosProdutos> Pratos = PP.listaPP();
                dgvPratosProdutos.DataSource = Pratos;
                dgvPratosProdutos.Columns.Remove("IdIng");
                dgvPratosProdutos.Columns.Remove("IdIngRetorno");
                dgvPratosProdutos.Columns.Remove("IdPPRetorno");
                for (var i = 0; i < clbIngredientes.Items.Count; i++)
                {
                    clbIngredientes.SetItemChecked(i, false);
                }
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
                lbIngredientes.Items.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar '"+nome+"'?", "Apagar Prato/dgvPratosProdutos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                PratosProdutos PP = new PratosProdutos();
                PP.apagarPrato(IdPP);
                MessageBox.Show("'" + nome + "' foi apagado com sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<PratosProdutos> Pratos = PP.listaPP();
                dgvPratosProdutos.DataSource = Pratos;
                dgvPratosProdutos.Columns.Remove("IdIng");
                dgvPratosProdutos.Columns.Remove("IdIngRetorno");
                dgvPratosProdutos.Columns.Remove("IdPPRetorno");
                for (var i = 0; i < clbIngredientes.Items.Count; i++)
                {
                    clbIngredientes.SetItemChecked(i, false);
                }
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
                lbIngredientes.Items.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sugestaotipo = new AutoCompleteStringCollection();
            con.Open();
            string sql = "SELECT DISTINCT tipo FROM PratosProdutos";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sugestaotipo.Add(dr["tipo"].ToString().Trim()); 
            }
            txtTipo.AutoCompleteCustomSource = sugestaotipo;
            con.Close();
        }
    }
}
