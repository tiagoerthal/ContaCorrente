using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        //string[] historicooperacao = new string[100];
        //int contadorHistorico = 0;

        public int numeroConta;
        public int limite;      
        public  double saldo;

        public static ContaCorrente CriarConta(int numero, int limiteInicial)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.numeroConta = numero;
            conta.limite = limiteInicial;
            conta.saldo = 0;
            return conta;
        }

        public void ObterSaque(double valor)
        {
            if (saldo <=0 || valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
             saldo -= valor;          
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Deposito invalido, valor: {valor}");
                return;
            }
            saldo += valor;
        }
        public void ObterSaldo(ContaCorrente conta)
        {
            Console.WriteLine($"Conta: {conta.numeroConta}, Saldo: {saldo}");
        }

        //public static double sacar(ContaCorrente conta, double valor)
        // {
        //return ContaCorrente.saldo -= valor;            
        // }


        //(int contador = 0; contador<contadorHistorico; contador++)
        // Console.WriteLine(historicooperacao[contador]);
    }
}
