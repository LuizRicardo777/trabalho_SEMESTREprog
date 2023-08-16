using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_SEMESTREprog
{
    public partial class aba_cadastro : Form
    {
        public aba_cadastro()
        {
            InitializeComponent();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            string name = txb_.Text;
            string enrollment = txb_pront.Text;

            string message = "nome: " + name +
                "\n matricula : " + enrollment;

            MessageBox.Show(
                message,
                "atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
