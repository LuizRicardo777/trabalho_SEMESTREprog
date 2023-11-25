using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace trabalho_SEMESTREprog
{
    public class Vagas
    {
        private string _vaga;
        private string _status;
        private string _placa;



        public Vagas(string vaga, string status, string placa)
        {

            Vaga = vaga;
            Status = status;
            Placa = placa;
       
        }

        public string Vaga
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");


                _vaga = value;
            }

            get { return _vaga; }
        }

        public string Status
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");


                _status = value;
            }

            get { return _status; }
        }


        public string Placa
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");


                _placa = value;
            }

            get { return _placa; }
        }
    }
}
