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


        private void desalocada_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void cad_carros_Click(object sender, EventArgs e)
        {
            aba_cadastro formscadastro = new aba_cadastro();
            formscadastro.ShowDialog();
        }

        private void ocupada3_Click(object sender, EventArgs e)
        {

        }

        private void ocupada_Click(object sender, EventArgs e)
        {

        }

        private void desocupada2_Click(object sender, EventArgs e)
        {

        }
        //===========================================================================
        //tela inicial(cabeçalho)================================
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void vaga_1_Click(object sender, EventArgs e)
        {

        }
        //=============================================================================================================================================================
        //=============================================================================================================================================================
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
