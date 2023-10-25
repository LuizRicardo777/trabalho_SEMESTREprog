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


                MessageBox.Show("cadastrado com suceso",//mensagem na tela
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


                MessageBox.Show("editado com sucesso com suceso",//mensagem na tela
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
