namespace _3
{
    public class ContaCorrente : Conta
    {
        public override double Rendimento()
        {
            return Saldo * 0.03;
        }

        public ContaCorrente(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
