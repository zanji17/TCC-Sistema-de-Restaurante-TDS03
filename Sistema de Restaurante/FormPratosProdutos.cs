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
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> lista = PP.listaTiposIngredientes();
            for (int i = 0; i < lista.Count; i++)
            {
                clbCategoria.Items.Add(lista[i].tipo);
            }
            List<PratosProdutos> lista2 = PP.listaIngredientes();
            for (int i = 0; i < lista2.Count; i++)
            {
                clbIngredientes.Items.Add(lista2[i].ingrediente);
            }
            List<PratosProdutos> Pratos = PP.listaPP();
            dgvPratosProdutos.DataSource = Pratos;
            dgvPratosProdutos.Columns[0].Width = 20;
            dgvPratosProdutos.Columns[1].Width = 50;
            dgvPratosProdutos.Columns[2].Width = 50;
            dgvPratosProdutos.Columns[3].Width = 70;
            dgvPratosProdutos.Columns[4].Width = 50;
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
            PratosProdutos PP = new PratosProdutos();
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
                List<PratosProdutos> lista = PP.listaIngredientesPorTipo(clbCategoria.SelectedItem.ToString());
                for (int i = 0; i < lista.Count; i++)
                {
                    clbIngredientes.Items.Add(lista[i].ingrediente);
                    for (int j = 0; j < clbRetirar.Items.Count; j++)
                    {
                        if (lista[i].ingrediente == clbRetirar.Items[j].ToString())
                        {
                            clbIngredientes.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else
            {
                List<PratosProdutos> lista = PP.listaIngredientes();
                for (int i = 0; i < lista.Count; i++)
                {
                    clbIngredientes.Items.Add(lista[i].ingrediente);
                    for (int j = 0; j < clbRetirar.Items.Count; j++)
                    {
                        if (lista[i].ingrediente == clbRetirar.Items[j].ToString())
                        {
                            clbIngredientes.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void clbIngredientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (clbIngredientes.SelectedItem != null)
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
            if (txtNome.Text != "" && txtNome.Text != null)
            {
                PratosProdutos pratosprodutos = new PratosProdutos();
                var cozinha = "N";
                if (ckCozinha.CheckState == CheckState.Checked)
                {
                    cozinha = "S";
                }
                pratosprodutos.InserirPrato(txtNome.Text.Trim(), txtTipo.Text.Trim(), cozinha);
                if (pratosprodutos.IdPPRetorno != 0)
                {
                    for (var i = 0; i < clbRetirar.Items.Count; i++)
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
            if (e.RowIndex >= 0)
            {
                clbIngredientes.ClearSelected();
                clbAdicional.ClearSelected();
                lbAdicional.Items.Clear();
                clbRetirar.Items.Clear();
                ckCozinha.Checked = false;
                PratosProdutos PP = new PratosProdutos();
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
                if (row.Cells[5].Value.ToString() == "S")
                {
                    ckCozinha.Checked = true;
                }
                List<PratosProdutos> lista = PP.listaPPIngredientes((int)row.Cells[0].Value);
                for (int k = 0; k < lista.Count; k++)
                {
                    for (var i = 0; i < clbIngredientes.Items.Count; i++)
                    {
                        if (clbIngredientes.Items[i].ToString().Trim() == lista[k].ingrediente)
                        {
                            clbRetirar.Items.Add(lista[k].ingrediente);
                            if (lista[k].tipo == "S")
                            {
                                for (int j = 0; j < clbRetirar.Items.Count; j++)
                                {
                                    if (lista[k].ingrediente == clbRetirar.Items[j].ToString().Trim())
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
                List<PratosProdutos> adicionais = PP.listarAdicionais(IdPP);
                for (int i = 0; i < adicionais.Count; i++)
                {
                    lbAdicional.Items.Add(adicionais[i].ingrediente);
                    for (int j = 0; j < clbAdicional.Items.Count; j++)
                    {
                        if (clbAdicional.Items[j].ToString() == adicionais[i].ingrediente.ToString())
                        {
                            clbAdicional.SetItemChecked(j, true);
                        }
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
                if (ckCozinha.CheckState == CheckState.Checked)
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
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar '" + nome + "'?", "Apagar Prato/dgvPratosProdutos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                PratosProdutos PP = new PratosProdutos();
                PP.apagarPrato(IdPP);
                MessageBox.Show("'" + nome + "' foi apagado com sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizar();
            }
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sugestaotipo = new AutoCompleteStringCollection();
            PratosProdutos PP = new PratosProdutos();
            List<PratosProdutos> lista = PP.listaTipoPP();
            for (int i = 0; i < lista.Count; i++)
            {
                sugestaotipo.Add(lista[i].tipo);
            }
            txtTipo.AutoCompleteCustomSource = sugestaotipo;
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
            dgvPratosProdutos.Columns[0].Width = 20;
            dgvPratosProdutos.Columns[1].Width = 50;
            dgvPratosProdutos.Columns[2].Width = 50;
            dgvPratosProdutos.Columns[3].Width = 70;
            dgvPratosProdutos.Columns[4].Width = 50;
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
            ckCozinha.Checked = false;
        }

        private void dgvPratosProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clbIngredientes.ClearSelected();
                clbAdicional.ClearSelected();
                lbAdicional.Items.Clear();
                clbRetirar.Items.Clear();
                ckCozinha.Checked = false;
                PratosProdutos PP = new PratosProdutos();
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
                if (row.Cells[5].Value.ToString() == "S")
                {
                    ckCozinha.Checked = true;
                }
                List<PratosProdutos> lista = PP.listaPPIngredientes((int)row.Cells[0].Value);
                for (int k = 0; k < lista.Count; k++)
                {
                    for (var i = 0; i < clbIngredientes.Items.Count; i++)
                    {
                        if (clbIngredientes.Items[i].ToString().Trim() == lista[k].ingrediente)
                        {
                            clbRetirar.Items.Add(lista[k].ingrediente);
                            if (lista[k].tipo == "S")
                            {
                                for (int j = 0; j < clbRetirar.Items.Count; j++)
                                {
                                    if (lista[k].ingrediente == clbRetirar.Items[j].ToString().Trim())
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
                List<PratosProdutos> adicionais = PP.listarAdicionais(IdPP);
                for (int i = 0; i < adicionais.Count; i++)
                {
                    lbAdicional.Items.Add(adicionais[i].ingrediente);
                    for (int j = 0; j < clbAdicional.Items.Count; j++)
                    {
                        if (clbAdicional.Items[j].ToString() == adicionais[i].ingrediente.ToString())
                        {
                            clbAdicional.SetItemChecked(j, true);
                        }
                    }
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string valor = txtValor.Text.Replace(",", "").Replace(".", "").Replace("R$", "");
            if (valor == "")
            {
                txtValor.Text = "R$0,00";
            }
            else if (valor.Length >= 4)
            {
                if (valor.Substring(0, 1) == "0")
                {
                    txtValor.Text = "R$" + valor.Substring(1, 1) + "," + valor.Substring(2, 2);
                }
                else
                {
                    txtValor.Text = "R$" + valor.Substring(0, valor.Length - 2) + "," + valor.Substring(valor.Length - 2, 2);
                }
            }
            else if (valor.Length < 3)
            {
                txtValor.Text = "R$" + 0 + "," + valor;
            }
            txtValor.SelectionStart = txtValor.Text.Length;
        }
    }
}
