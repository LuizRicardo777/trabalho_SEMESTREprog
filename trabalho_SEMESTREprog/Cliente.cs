using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_SEMESTREprog
{
    public class Cliente
    {
        private string _id;
        private string _nome;
        private string _cpf;
        private string _carro;

        public Cliente(string id, string nome, string cpf, string carro) {

            Id = id;
            Nome = nome;
            Cpf = cpf;
            Carro = carro;
        
        }

        public string Id
        {
            set { _id = value; }  
            get { return _id; }
        }

        public string Nome
        {
            set { _nome = value; }  
            get { return _nome; }
        }

        public string Cpf
        {
            set { _cpf = value; }  
            get { return _cpf; }
        } 

        public string Carro
        {
            set { _carro = value; }  
            get { return _carro; }
        }


    }
}
