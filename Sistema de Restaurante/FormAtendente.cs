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
        public FormAtendente()
        {
            InitializeComponent();
        }

        public int IdAtendente { get; set; }
        public int IdAcesso { get; set; }

        

        private void btnCadAtend_Click_1(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Inserir(txtNome.Text, txtCpf.Text, txtLogin.Text, txtSenha.Text);
            MessageBox.Show("Atendente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Atendente> Atendentes = atendente.listaAtendentes();
            dgvAtend.DataSource = Atendentes;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Atualizar(IdAtendente,IdAcesso , txtNome.Text, txtCpf.Text, txtLogin.Text, txtSenha.Text);
            MessageBox.Show("Atendente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Atendente> atendentes = atendente.listaAtendentes();
            dgvAtend.DataSource = atendentes;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty; 
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo apagar este atendente?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                
                Atendente atendente = new Atendente();
                atendente.Excluir(IdAtendente, IdAcesso);
                MessageBox.Show("Atendente excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Atendente> atendentes = atendente.listaAtendentes();
                dgvAtend.DataSource = atendentes;
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                IdAtendente = 0;
                IdAcesso = 0;
            }
        }

        private void btnSairCadAtend_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormAtendente_Load(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            List<Atendente> atendentes = atendente.listaAtendentes();
            dgvAtend.DataSource = atendentes;
        }
    }
}

