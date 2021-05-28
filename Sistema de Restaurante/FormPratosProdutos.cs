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

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");
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
                clbCategoria.Items.Add(dr["tipo"].ToString().Trim());
            }
            con.Close();
            con.Open();
            string ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
            SqlCommand cmdingred = new SqlCommand(ingred, con);
            SqlDataReader dringred = cmdingred.ExecuteReader();
            while (dringred.Read())
            {
                clbIngredientes.Items.Add(dringred["nome"].ToString().Trim());   
            }
            con.Close();
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> Pratos = PP.listaPP();
            dgvPratosProdutos.DataSource = Pratos;
            dgvPratosProdutos.Columns.Remove("IdIng");
            dgvPratosProdutos.Columns.Remove("IdIngRetorno");
            dgvPratosProdutos.Columns.Remove("IdPPRetorno");
            ModeloAdicional modelo = new ModeloAdicional();
            List<ModeloAdicional> adicionais = modelo.listarAdicionais();
            for (int i = 0; i < adicionais.Count; i++)
            {
                clbAdicional.Items.Add(adicionais[i].Adicionais);
            }
            List<PratosProdutos> modelos = PP.CarregaModelos();
            cbModelo.Items.Add("none");
            for (int i = 0; i < modelos.Count; i++)
            {
                cbModelo.Items.Add(modelos[i].ingrediente);
            }
            cbModelo.SelectedIndex = 0;
        }

        private void clbCategoria_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            clbIngredientes.Items.Clear();
            clbIngredientes.ClearSelected();
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
                        clbIngredientes.Items.Add(dt.Rows[i]["nome"].ToString().Trim());
                        for (int j = 0; j < clbRetirar.Items.Count; j++)
                        {
                            if(dt.Rows[i]["nome"].ToString().Trim() == clbRetirar.Items[j].ToString())
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
                        clbIngredientes.Items.Add(dt2.Rows[i]["nome"].ToString().Trim());
                        foreach (object ingrediente in clbRetirar.Items)
                        {
                            if (dt2.Rows[i]["nome"].ToString().Trim() == ingrediente.ToString())
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
            if (e.NewValue == CheckState.Checked) 
            {
                if(clbIngredientes.SelectedItem != null)
                {
                    clbRetirar.Items.Add(clbIngredientes.SelectedItem);
                }
            }
            else
            {
                if (clbIngredientes.SelectedItem != null)
                {
                    for (int i = 0; i < clbRetirar.Items.Count; i++)
                    {
                        if (clbRetirar.Items[i].ToString() == clbIngredientes.SelectedItem.ToString())
                        {
                            clbRetirar.Items.Remove(clbRetirar.Items[i]);
                        }
                    }
                }
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtNome.Text != null)
            {
                PratosProdutos pratosprodutos = new PratosProdutos();
                var cozinha = "N";
                if (chkCozinha.CheckState == CheckState.Checked)
                {
                    cozinha = "S";
                }
                pratosprodutos.InserirPrato(txtNome.Text.Trim(), txtTipo.Text.Trim(), cozinha);
                if (pratosprodutos.IdPPRetorno != 0)
                {
                    for(var i = 0; i < clbRetirar.Items.Count; i++)
                    {
                        pratosprodutos.IdIngred(clbRetirar.Items[i].ToString());
                        var retiravel = "N";
                        if (clbRetirar.GetItemChecked(i) == true)
                        {
                            retiravel = "S";
                        }
                        pratosprodutos.PratosIngred(pratosprodutos.IdPPRetorno, pratosprodutos.IdIngRetorno, retiravel);
                    }
                    foreach (var nomeing in lbAdicional.Items)
                    {
                        pratosprodutos.IdIngred(nomeing.ToString());
                        pratosprodutos.PratosAdicional(pratosprodutos.IdPPRetorno, pratosprodutos.IdIngRetorno);
                    }
                    MessageBox.Show("Prato ou Produto Cadastrado com Sucesso!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizar();
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
            clbAdicional.ClearSelected();
            lbAdicional.Items.Clear();
            clbRetirar.Items.Clear();
            chkCozinha.Checked = false;
            for (var i = 0; i < clbCategoria.Items.Count; i++)
            {
                clbCategoria.SetItemChecked(i, false);
            }
            for (var i = 0; i < clbIngredientes.Items.Count; i++)
            {
                clbIngredientes.SetItemChecked(i, false);
            }
            for (var i = 0; i < clbAdicional.Items.Count; i++)
            {
                clbAdicional.SetItemChecked(i, false);
            }
            DataGridViewRow row = this.dgvPratosProdutos.Rows[e.RowIndex];
            txtNome.Text = row.Cells[1].Value.ToString().Trim();
            txtTipo.Text = row.Cells[2].Value.ToString().Trim();
            if(row.Cells[5].Value.ToString() == "S")
            {
                chkCozinha.Checked = true;
            }
            con.Open();
            string sql = "SELECT Ingredientes.nome, PratosProdutosIngredientes.retiravel FROM PratosProdutos INNER JOIN PratosProdutosIngredientes ON PratosProdutos.IdPratoProduto = PratosProdutosIngredientes.IdPratosProdutos INNER JOIN Ingredientes ON PratosProdutosIngredientes.IdIngredientes = Ingredientes.IdIngrediente WHERE IdPratoProduto = @Id ORDER BY nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (var i = 0; i < clbIngredientes.Items.Count; i++)
                {
                    if(clbIngredientes.Items[i].ToString().Trim() == dr["nome"].ToString().Trim())
                    {
                        clbRetirar.Items.Add(dr["nome"].ToString().Trim());
                        if(dr["retiravel"].ToString().Trim() == "S")
                        {
                            for (int j = 0; j < clbRetirar.Items.Count; j++)
                            {
                                if(dr["nome"].ToString().Trim() == clbRetirar.Items[j].ToString().Trim())
                                {
                                    clbRetirar.SetItemChecked(j, true);
                                }
                            }
                        }
                        clbIngredientes.SetItemChecked(i, true);
                    }
                }
            }
            con.Close();
            IdPP = Convert.ToInt32(row.Cells[0].Value);
            nome = row.Cells[1].Value.ToString();
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> adicionais = PP.listarAdicionais(IdPP);
            for (int i = 0; i < adicionais.Count; i++)
            {
                lbAdicional.Items.Add(adicionais[i].ingrediente);
                for (int j = 0; j < clbAdicional.Items.Count; j++)
                {
                    if(clbAdicional.Items[j].ToString() == adicionais[i].ingrediente.ToString())
                    {
                        clbAdicional.SetItemChecked(j, true);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNome.Text != null)
            {
                PratosProdutos PP = new PratosProdutos();
                var cozinha = "N";
                if (chkCozinha.CheckState == CheckState.Checked)
                {
                    cozinha = "S";
                }
                PP.atualizarPrato(txtNome.Text.Trim(), txtTipo.Text.Trim(), IdPP, cozinha);
                PP.RenovarIng(IdPP);
                for (int i = 0; i < clbRetirar.Items.Count; i++)
                {
                    PP.IdIngred(clbRetirar.Items[i].ToString());
                    var retiravel = "N";
                    if (clbRetirar.GetItemChecked(i) == true)
                    {
                        retiravel = "S";
                    }
                    PP.PratosIngred(IdPP, PP.IdIngRetorno, retiravel);
                }
                foreach (var nomeing in lbAdicional.Items)
                {
                    PP.IdIngred(nomeing.ToString());
                    PP.PratosAdicional(IdPP, PP.IdIngRetorno);
                }
                MessageBox.Show("Prato ou Produto Atualizado com Sucesso!!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizar();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar '"+nome+"'?", "Apagar Prato/dgvPratosProdutos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                PratosProdutos PP = new PratosProdutos();
                PP.apagarPrato(IdPP);
                MessageBox.Show("'" + nome + "' foi apagado com sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizar();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeloAdicional modelo = new ModeloAdicional();
            lbAdicional.Items.Clear();
            clbAdicional.ClearSelected();
            for (int i = 0; i < clbAdicional.Items.Count; i++)
            {
                clbAdicional.SetItemChecked(i, false);
            }
            if (cbModelo.SelectedItem.ToString() != "none")
            {
                List<ModeloAdicional> marcar = modelo.BuscaAdicionais(cbModelo.SelectedItem.ToString());
                for (int i = 0; i < marcar.Count; i++)
                {
                    lbAdicional.Items.Add(marcar[i].Adicionais);
                    for (int j = 0; j < clbAdicional.Items.Count; j++)
                    {
                        if (clbAdicional.Items[j].ToString() == marcar[i].Adicionais.ToString())
                        {
                            clbAdicional.SetItemChecked(j, true);
                        }
                    }
                }
            }
        }

        private void clbAdicional_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (clbAdicional.SelectedItem != null)
                {
                    lbAdicional.Items.Add(clbAdicional.SelectedItem);
                }
            }
            else
            {
                lbAdicional.Items.Remove(clbAdicional.SelectedItem);
            }
        }

        public void atualizar()
        {
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> Pratos = PP.listaPP();
            dgvPratosProdutos.DataSource = Pratos;
            dgvPratosProdutos.Columns.Remove("IdIng");
            dgvPratosProdutos.Columns.Remove("IdIngRetorno");
            dgvPratosProdutos.Columns.Remove("IdPPRetorno");
            for (var i = 0; i < clbIngredientes.Items.Count; i++)
            {
                clbIngredientes.SetItemChecked(i, false);
            }
            for (var i = 0; i < clbAdicional.Items.Count; i++)
            {
                clbAdicional.SetItemChecked(i, false);
            }
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            clbAdicional.ClearSelected();
            clbIngredientes.ClearSelected();
            lbAdicional.Items.Clear();
            clbRetirar.Items.Clear();
            IdPP = 0;
            nome = string.Empty;
            chkCozinha.Checked = false;
        }
    }
}
