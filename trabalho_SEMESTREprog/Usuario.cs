using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace trabalho_SEMESTREprog
{
    public class Usuario
    {
        private string _nome;
        private string _senha;
        public Usuario (string nome, string senha)
        {

            Nome = nome;
            Senha = senha;

        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");

                _nome = value;
            }
            get { return _nome; }
        }

        public string Senha
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");

                _senha = value;
            }
            get { return _senha; }
        }

    }
}
