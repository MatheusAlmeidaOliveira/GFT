namespace _3
{
    public class ContaPoupanca : Conta
    {
        public override double Rendimento()
        {
            return Saldo * 0.05;
        }

        public ContaPoupanca(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
