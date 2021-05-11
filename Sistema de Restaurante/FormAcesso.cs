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
    public partial class FormAcesso : Form
    {
        public int Id { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Restaurante\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormAcesso()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != "" && txtLogin.Text != null) && (txtSenha.Text != "" && txtSenha != null))
            {
                Acesso acesso = new Acesso();
                acesso.Inserir(txtLogin.Text, txtSenha.Text, cbCargo.Text);
                List<Acesso> li = acesso.listarAcesso();
                dgvAcesso.DataSource = li;
                MessageBox.Show("Conta Cadastrada com Sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                cbCargo.SelectedIndex = 0;
            }
        }

        private void FormAcesso_Load(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            List<Acesso> li = acesso.listarAcesso();
            dgvAcesso.DataSource = li;
            cbCargo.Items.Add("Gerente");
            cbCargo.Items.Add("Cozinha");
            cbCargo.Items.Add("Caixa");
            cbCargo.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != "" && txtLogin.Text != null) && (txtSenha.Text != "" && txtSenha != null))
            {
                Acesso acesso = new Acesso();
                acesso.Atualizar(txtLogin.Text, txtSenha.Text, cbCargo.Text, Id);
                List<Acesso> li = acesso.listarAcesso();
                dgvAcesso.DataSource = li;
                MessageBox.Show("Conta Atualizada com Sucesso!!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                cbCargo.SelectedIndex = 0;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja mesmo apagar essa conta de acesso?","Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Acesso acesso = new Acesso();
                acesso.Apagar(Id);
                List<Acesso> li = acesso.listarAcesso();
                dgvAcesso.DataSource = li;
                MessageBox.Show("Conta Apagada com Sucesso!!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                cbCargo.SelectedIndex = 0;
            }
        }

        private void dgvAcesso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAcesso.Rows[e.RowIndex];
            txtLogin.Text = row.Cells[1].Value.ToString().Trim();
            txtSenha.Text = row.Cells[2].Value.ToString().Trim();
            cbCargo.SelectedItem = row.Cells[3].Value.ToString().Trim();
            Id = (int) row.Cells[0].Value;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cbCargo.SelectedIndex = 0;
            Id = 0;
        }
    }
}
