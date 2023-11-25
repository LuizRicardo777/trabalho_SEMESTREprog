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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabalho_SEMESTREprog
{
    public partial class Form1 : Form
    {
        public Form1()
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
        //=================================================================================================================
        //=================================================================================================================




        private void cad_carros_Click(object sender, EventArgs e)
        {
            aba_cadastro formscadastro = new aba_cadastro();
            formscadastro.ShowDialog();
        }




        //===========================================================================
        //tela inicial(cabeçalho)================================
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }


        //=============================================================================================================================================================
        //=============================================================================================================================================================
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tela_vagas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cad_funcionario_Click(object sender, EventArgs e)
        {
            aba_usuario formscadastro = new aba_usuario(1);
            formscadastro.ShowDialog();
        }

        private void visu_vagas_Click(object sender, EventArgs e)
        {
            visu_vagas formscadastro = new visu_vagas();
            formscadastro.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

       
        //===============================================
        private void OCUP1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void CAD_VAGAS_Click_1(object sender, EventArgs e)
        {
            Cad_vagas formscadastro = new Cad_vagas();
            formscadastro.ShowDialog();
        }
    }
}

