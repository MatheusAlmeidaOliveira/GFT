namespace _3
{
    public abstract class Conta
    {
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        
        private string _titular;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public abstract double Rendimento();

    }
}
