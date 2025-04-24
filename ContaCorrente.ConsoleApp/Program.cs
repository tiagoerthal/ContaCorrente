namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.saldo = 1000;
            conta1.numeroConta = 12;
            conta1.limite = 0;          

            conta1.ObterSaque(200);

            conta1.Depositar(300);

            conta1.Depositar(500);

            conta1.ObterSaque(200);

            conta1.ObterSaldo();

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 300;
            conta2.numeroConta = 13;
            conta2.limite = 0;

            conta2.ObterSaldo();

            conta1.Transferir(conta2, 400);

            conta1.ExibirExtrato();

            conta2.Transferir(conta1, 200);
        
            conta1.ObterSaldo();

            conta2.ObterSaldo();

            conta2.ExibirExtrato();

            Console.ReadLine();

        }
    }
}
