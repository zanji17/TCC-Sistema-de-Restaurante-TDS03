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

        public FormAcesso()
        {
            InitializeComponent();
        }

        private void FormAcesso_Load(object sender, EventArgs e)
        {
            cbCargo.Items.Add("Gerente");
            cbCargo.Items.Add("Cozinha");
            cbCargo.Items.Add("Caixa");
            cbCargo.SelectedIndex = 0;
            atualizaDGV();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != "" && txtLogin.Text != null) && (txtSenha.Text != "" && txtSenha != null))
            {
                Acesso acesso = new Acesso();
                acesso.Inserir(txtLogin.Text, txtSenha.Text, cbCargo.Text);
                atualizaDGV();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != "" && txtLogin.Text != null) && (txtSenha.Text != "" && txtSenha != null))
            {
                Acesso acesso = new Acesso();
                acesso.Atualizar(txtLogin.Text, txtSenha.Text, cbCargo.Text, Id);
                atualizaDGV();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (sugestao sg = new sugestao("Deseja mesmo apagar essa conta de acesso ?") { })
            {
                if (sg.ShowDialog() == DialogResult.Yes)
                {
                    Acesso acesso = new Acesso();
                    acesso.Apagar(Id);
                    atualizaDGV();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFechar_Click(object sender, EventArgs e)
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

        public void atualizaDGV()
        {
            Acesso acesso = new Acesso();
            List<Acesso> li = acesso.listarAcesso();
            dgvAcesso.DataSource = li;
            dgvAcesso.Columns[0].Width = 54;
            dgvAcesso.Columns[1].Width = 130;
            dgvAcesso.Columns[2].Width = 130;
            dgvAcesso.Columns[3].Width = 100;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cbCargo.SelectedIndex = 0;
        }

        private void dgvAcesso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAcesso.Rows[e.RowIndex];
                txtLogin.Text = row.Cells[1].Value.ToString().Trim();
                txtSenha.Text = row.Cells[2].Value.ToString().Trim();
                cbCargo.SelectedItem = row.Cells[3].Value.ToString().Trim();
                Id = (int)row.Cells[0].Value;
            }
        }
    }
}
