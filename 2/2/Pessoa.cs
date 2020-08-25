using System;

namespace _2
{
    public class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        
        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                double result;
                if (Double.TryParse(value, out result))
                    _telefone = value;
                else
                    throw new Exception("Digite somente numeros inteiros");
            }
        }

        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
