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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gusta\\OneDrive\\Documentos\\TCC 2021\\restaurante-main\\Sistema de Restaurante\\Restaurante.mdf;Integrated Security=True");

        public FormAcesso()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            dgvAcesso.Columns.Add("ID", "ID");
            dgvAcesso.Columns.Add("Login", "Login");
            dgvAcesso.Columns.Add("Senha", "Senha");
            dgvAcesso.Columns.Add("Cargo", "Cargo");
        }

        private void BtnCadSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
