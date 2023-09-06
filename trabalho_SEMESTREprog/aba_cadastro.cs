using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO cadastro VALUES
            (@Id, @Cpf, @Carro, @Nome)";

            sqlCommand.Parameters.AddWithValue("@Id", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Nome", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@Cpf", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@Carro", textBox2.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("cadastrado com suceso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //campo para escrever o carro
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //campo para escrever o CPF
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //campo para escrever o nome
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //campo para escrever a placa(id)
        }
    }
}
