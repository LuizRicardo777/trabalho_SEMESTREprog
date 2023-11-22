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

