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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gusta\\OneDrive\\Documentos\\TCC 2021\\Restaurante\\Restaurante.mdf;Integrated Security=True");
        public FormPratosProdutos()
        {
            InitializeComponent();
        }

        private void FormPratosProdutos_Load(object sender, EventArgs e)
        {
            con.Open();
            String 
        }
    }
}
