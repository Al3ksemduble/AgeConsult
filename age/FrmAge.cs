using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age
{
    public partial class FrmAge : Form
    {
        public FrmAge()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Por favor, digite uma idade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idade >= 18)
            {
                lblResult.Text = "Você é maior de idade!";
            }
            else
            {
                lblResult.Text = "Você é menor de idade!";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtIdade.Focus();
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
