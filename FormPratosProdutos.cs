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
            String ctg = "SELECT DISTINCT Tipo FROM Ingredientes";
            SqlCommand cmd = new SqlCommand(ctg, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int linhas = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < linhas; i++)
                {
                    clbCategoria.Items.Add(dt.Rows[i]["Tipo"].ToString());
                }
            }
            con.Close();
            con.Open();
            String ingred = "SELECT nome FROM Ingredientes ORDER BY nome";
            SqlCommand cmdingred = new SqlCommand(ingred, con);
            SqlDataAdapter daingred = new SqlDataAdapter(cmdingred);
            DataTable dtingred = new DataTable();
            daingred.Fill(dtingred);
            int linhasingred = dtingred.Rows.Count;
            if (dtingred.Rows.Count > 0)
            {
                for (int i = 0; i < linhasingred; i++)
                {
                    clbIngredientes.Items.Add(dtingred.Rows[i]["nome"].ToString());
                }
            }
            con.Close();
        }
    }
}
