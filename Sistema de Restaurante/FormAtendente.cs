using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FormAtendente : Form
    {
        public int IdAtendente { get; set; }
        public int IdAcesso { get; set; }

        public FormAtendente()
        {
            InitializeComponent();
        }

        private void btnCadAtend_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Inserir(txtNome.Text, txtCpf.Text, txtLogin.Text, txtSenha.Text);
            atualizaDGV();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Atualizar(IdAtendente, IdAcesso, txtNome.Text, txtCpf.Text, txtLogin.Text, txtSenha.Text);
            atualizaDGV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            using (sugestao sg = new sugestao("Deseja mesmo Excluir esse Atendente ?") { })
            {
                if (DialogResult.Yes == sg.ShowDialog())
                {
                    Atendente atendente = new Atendente();
                    atendente.Excluir(IdAtendente, IdAcesso);
                    atualizaDGV();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            IdAtendente = 0;
            IdAcesso = 0;
        }

        private void dgvAtend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAtend.Rows[e.RowIndex];
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCpf.Text = row.Cells[2].Value.ToString();
                txtLogin.Text = row.Cells[4].Value.ToString();
                txtSenha.Text = row.Cells[5].Value.ToString();
                IdAtendente = (int)row.Cells[0].Value;
                IdAcesso = (int)row.Cells[3].Value;
            }
        }

        public void atualizaDGV()
        {
            Atendente atendente = new Atendente();
            List<Atendente> atendentes = atendente.listaAtendentes();
            dgvAtend.DataSource = atendentes;
            dgvAtend.Columns[0].HeaderText = "Id Atendente";
            dgvAtend.Columns[3].HeaderText = "Id Acesso";
            dgvAtend.Columns[0].Width = 54;
            dgvAtend.Columns[3].Width = 54;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            IdAtendente = 0;
            IdAcesso = 0;
        }

        private void FormAtendente_Load(object sender, EventArgs e)
        {
            atualizaDGV();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
