using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabalho_SEMESTREprog
{
    public partial class Cad_vagas : Form
    {
        public Cad_vagas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SALVAR3_Click(object sender, EventArgs e)
        {
            try
            {
                //criar objeto
                Vagas vagas = new Vagas(tbt_vaga.Text, tbt_placa.Text, cmb_status.Text);

                //chamar classe
                VagasDAO vagaDAO = new VagasDAO();
                vagaDAO.SalvarUser(vagas);
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
            tbt_vaga.Clear();
            tbt_placa.Clear();
            cmb_status.SelectedIndex = 0;
           

            UpdateListView();


        }

        private void Cad_vagas_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            lv_vagas.Items.Clear();

            VagasDAO vagasDAO = new VagasDAO();
            List<Vagas> vaga = vagasDAO.SelectVagas();


            try
            {

                foreach (Vagas vagas in vaga)
                {

                    ListViewItem lv = new ListViewItem( vagas.Vaga.ToString());
                    lv.SubItems.Add(vagas.Placa);
                    lv.SubItems.Add(vagas.Status);
                    lv_vagas.Items.Add(lv);
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void lv_vagas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_vagas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = lv_vagas.FocusedItem.Index;

            tbt_vaga.Text = lv_vagas.Items[index].SubItems[0].Text;
            tbt_placa.Text = lv_vagas.Items[index].SubItems[1].Text;
            cmb_status.Text = lv_vagas.Items[index].SubItems[2].Text;
            
        }

        private void EDITAR3_Click(object sender, EventArgs e)
        {
            try
            {
                //criar objeto
                Vagas vagas  = new Vagas(tbt_vaga.Text, tbt_placa.Text, cmb_status.Text);

                //chamar classe
                VagasDAO vagaDAO = new VagasDAO();
                vagaDAO.AtualizarVagas(vagas);


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
            tbt_vaga.Clear();
            tbt_placa.Clear();
            cmb_status.SelectedIndex = 0;
            

            UpdateListView();
        }

        private void REMOVER3_Click(object sender, EventArgs e)
        {
            //chamar classe
            VagasDAO vagaDAO = new VagasDAO();
            vagaDAO.DeleteVagas(tbt_vaga.Text);



            //limpar
            tbt_vaga.Clear();
            tbt_placa.Clear();
            cmb_status.SelectedIndex = 0;

            //atualizar
            UpdateListView();

            MessageBox.Show("deletado com suceso",//mensagem na tela
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
   }

