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
        //private string Id;

        public aba_cadastro()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id,Nome, Carro FROM cadastro";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    string id = (string)dr["Id"];
                    string Nome = (string)dr["Nome"];
                    string Carro = (string)dr["Carro"];


                    ListViewItem lv = new ListViewItem(id);
                    lv.SubItems.Add(Nome);
                    lv.SubItems.Add(Carro);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
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

            MessageBox.Show("cadastrado com suceso",//mensagem na tela
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //limpar os campos
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();

            UpdateListView();

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

        private void editar_Click(object sender, EventArgs e)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE cadastro SET
                    Id = @Id,
                  Cpf = @Cpf,
                  Carro =  @Carro,
                  Nome = @Nome
                  WHERE Id = @Id";

            sqlCommand.Parameters.AddWithValue("@Id", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Nome", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@Cpf", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@Carro", textBox2.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("editado com suceso",//mensagem na tela
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //limpar os campos
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();

            UpdateListView();
        }

        private void aba_cadastro_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
           
            textBox1.Text = listView1.Items[index].SubItems[0].Text;
            textBox4.Text = listView1.Items[index].SubItems[1].Text;
            textBox2.Text = listView1.Items[index].SubItems[2].Text;
            textBox3.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
           //chamar classe
           ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.DeleteUser(textBox1.Text);



            //limpar
                textBox1.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();

            //atualizar
                UpdateListView();

            MessageBox.Show("deletado com suceso",//mensagem na tela
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
