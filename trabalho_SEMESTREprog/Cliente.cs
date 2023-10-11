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
            set {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");


                _id = value; }  

            get { return _id; }
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" +
                        "por favor preencha");

                _nome = value; }  
            get { return _nome; }
        }

        public string Cpf
        {
            set {if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" + "por favor preencha");


                _cpf = value; }  
            get { return _cpf; }
        } 

        public string Carro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("valor vazio!" + "por favor preencha");

                _carro = value; }  
            get { return _carro; }
        }


    }
}
