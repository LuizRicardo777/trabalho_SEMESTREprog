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
    public partial class visu_vagas : Form
    {
        public visu_vagas()
        {
            InitializeComponent();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void UpdateListView()
        {
            listView1.Items.Clear();

            VagasDAO vagasDAO = new VagasDAO();
            List<Vagas> vaga = vagasDAO.SelectVagas();


            try
            {

                foreach (Vagas vagas in vaga)
                {

                    ListViewItem lv = new ListViewItem(vagas.Vaga.ToString());
                    lv.SubItems.Add(vagas.Placa);
                    lv.SubItems.Add(vagas.Status);
                    listView1.Items.Add(lv);
                   // lv.BackColor = vagas.Status.ToLower() == "ocupado" ? Color.LightCoral : SystemColors.Window;

                  //  listView1.Items.Add(lv);
                
            }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void visu_vagas_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
