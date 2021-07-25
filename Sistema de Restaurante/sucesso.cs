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
    public partial class sucesso : Form
    {
        public sucesso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar1.Increment(3);
            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
