using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace trabalho_SEMESTREprog
{
    public partial class aba_usuario : Form
    {
        private int tipo;
        public aba_usuario(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if(tipo == 0)
            {
                SALVAR2.Text = "LOGIN";
            }
            else
            {
                SALVAR2.Text = "SALVAR";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SALVAR2_Click(object sender, EventArgs e)
        {
            //botao salvar
            try
            {
                if (tipo == 0)
                {
                    //criar objeto
                    Usuario usuario = new Usuario(tbt_nome.Text, tbt_senha.Text);

                    //chamar classe
                     MessageBox.Show("SISTEMA EM FUNCIONAMENTO!",//mensagem na tela
                    "BEM VINDO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    UsuarioDAO usuariDAO = new UsuarioDAO();
                    if (usuariDAO.LoginUser(usuario))
                    {
                        Form1 form = new Form1();
                        form.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("usuário ou senha incorretos",//mensagem na tela
                    "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }

                }
                else
                {
                    //criar objeto
                    Usuario usuario = new Usuario(tbt_nome.Text, tbt_senha.Text);

                    //chamar classe
                    UsuarioDAO usuariDAO = new UsuarioDAO();
                    usuariDAO.SalvarUser(usuario);
                    MessageBox.Show("cadastrado com sucesso",//mensagem na tela
                    "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }





            //limpar os campos
            tbt_nome.Clear();
            tbt_senha.Clear();

        }

        private void aba_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
