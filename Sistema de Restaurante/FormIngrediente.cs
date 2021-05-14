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
    public partial class FormIngrediente : Form
    {
        public int Id { get; set; }
        public string nome { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");


        public FormIngrediente()
        {
            InitializeComponent();
        }

        private void FormIngrediente_Load(object sender, EventArgs e)
        {
            Ingrediente ingred = new Ingrediente();
            List<Ingrediente> listaingred = ingred.listarIngred();
            dgvIngred.DataSource = listaingred;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "" && txtNome.Text != null) && (txtTipo.Text != "" && txtTipo != null))
            {
                Ingrediente ingred = new Ingrediente();
                string adicional = "N";
                if (ckAdicional.CheckState == CheckState.Checked)
                {
                    adicional = "S";
                }
                ingred.Inserir(txtNome.Text, txtTipo.Text, adicional, txtDetalhes.Text);
                List<Ingrediente> listaingred = ingred.listarIngred();
                dgvIngred.DataSource = listaingred;
                MessageBox.Show("Ingrediente Cadastrado com Sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
                txtDetalhes.Text = string.Empty;
                ckAdicional.Checked = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "" && txtNome.Text != null) && (txtTipo.Text != "" && txtTipo != null))
            {
                Ingrediente ingred = new Ingrediente();
                string adicional = "N";
                if (ckAdicional.CheckState == CheckState.Checked)
                {
                    adicional = "S";
                }
                ingred.Atualizar(txtNome.Text, txtTipo.Text, adicional, txtDetalhes.Text, Id);
                List<Ingrediente> listaingred = ingred.listarIngred();
                dgvIngred.DataSource = listaingred;
                MessageBox.Show("Ingrediente Atualizado com Sucesso!!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
                txtDetalhes.Text = string.Empty;
                ckAdicional.Checked = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo apagar o ingrediente: '"+nome+"'?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Ingrediente Ingred = new Ingrediente();
                Ingred.Apagar(Id);
                List<Ingrediente> listaingred = Ingred.listarIngred();
                dgvIngred.DataSource = listaingred;
                MessageBox.Show("Ingrediente Apagado com Sucesso!!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
                txtDetalhes.Text = string.Empty;
                ckAdicional.Checked = false;
            }
        }

        private void dgvIngred_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvIngred.Rows[e.RowIndex];
            txtNome.Text = row.Cells[1].Value.ToString().Trim();
            txtTipo.Text = row.Cells[2].Value.ToString().Trim();
            if (row.Cells[3].Value.ToString().Trim() == "S") 
            {
                ckAdicional.Checked = true;
            }
            else
            {
                ckAdicional.Checked = false;
            }
            txtDetalhes.Text = row.Cells[4].Value.ToString().Trim();
            Id = (int)row.Cells[0].Value;
            nome = row.Cells[1].Value.ToString().Trim();
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sugestaotipo = new AutoCompleteStringCollection();
            con.Open();
            string sql = "SELECT DISTINCT Tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sugestaotipo.Add(dr["Tipo"].ToString().Trim());
            }
            txtTipo.AutoCompleteCustomSource = sugestaotipo;
            con.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDetalhes.Text = string.Empty;
            ckAdicional.Checked = false;
        }
    }
}
