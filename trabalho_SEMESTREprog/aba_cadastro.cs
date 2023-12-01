using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace trabalho_SEMESTREprog
{
    public partial class aba_cadastro : Form
    {
        

        public aba_cadastro()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

           ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clienteDAO.SelectUser();


            try
            {

                foreach (Cliente cliente in clientes)
                {

                    ListViewItem lv = new ListViewItem(cliente.Id.ToString());
                    lv.SubItems.Add(cliente.Nome);
                    lv.SubItems.Add(cliente.Carro);
                    lv.SubItems.Add(cliente.Cpf);
                    listView1.Items.Add(lv);
                }
            
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }


        private void confirmar_Click(object sender, EventArgs e)
        {
            try
            {
            //criar objeto
            Cliente cliente = new Cliente(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text);

                //chamar classe
                ClienteDAO clientDAO = new ClienteDAO();
                clientDAO.SalvarUser(cliente);


                MessageBox.Show("cadastrado com sucesso",//mensagem na tela
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            


            

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
            try
            {
                //criar objeto
                Cliente cliente = new Cliente(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text);

                //chamar classe
                ClienteDAO clientDAO = new ClienteDAO();
                clientDAO.AtualizarUser(cliente);


                MessageBox.Show("editado com sucesso com sucesso",//mensagem na tela
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

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
            textBox3.Text = listView1.Items[index].SubItems[3].Text;
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

            MessageBox.Show("deletado com sucesso",//mensagem na tela
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RELATORIO_Click(object sender, EventArgs e)
        {
            //aqui temos o botao de gera o pdf a partir das colunas do nosso banco de dados 
            // Conexão com o banco de dados SQL Server
            string stringConnection = @"Data Source="
                     + Environment.MachineName +
                     @"\SQLEXPRESS;Initial Catalog=" +
                     "estacionamento" + ";Integrated Security=true";
            SqlConnection connection = new SqlConnection(stringConnection);
            connection.Open();

            // Consulta SQL para recuperar as informações
            string query = "SELECT Id, Cpf, Carro, Nome FROM cadastro";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Cria um novo documento PDF
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("arquivo.pdf", FileMode.Create));
            document.Open();

            // Cria uma nova tabela e adiciona as informações recuperadas
            PdfPTable table = new PdfPTable(4);
            table.AddCell("Id");
            table.AddCell("Cpf");
            table.AddCell("Carro");
            table.AddCell("Nome");

            while (reader.Read())
            {
                table.AddCell(reader["Id"].ToString());
                table.AddCell(reader["Cpf"].ToString());
                table.AddCell(reader["Carro"].ToString());
                table.AddCell(reader["Nome"].ToString());
            }

            // Adiciona a tabela ao documento
            document.Add(table);

            // Fecha o documento e a conexão com o banco de dados
            document.Close();
            connection.Close();

            MessageBox.Show(
            "RELATORIO GERADO COM SUCESSO",
            "ATENÇÃO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
    }

