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

        public int numero;
        public int limite;
        //public int sacar;
        //public int depositar;
        public  double saldo;

        public static ContaCorrente CriarConta(int numero, int limiteInicial)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.numero = numero;
            conta.limite = limiteInicial;
            conta.saldo = 0;
            return conta;
        }

        public void obtersaque(double valor)
        {
            if (saldo <=0 || valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
             saldo -= valor;          
        }

        //public static double sacar(ContaCorrente conta, double valor)
       // {
            //return ContaCorrente.saldo -= valor;            
       // }
       

             //(int contador = 0; contador<contadorHistorico; contador++)
                  // Console.WriteLine(historicooperacao[contador]);
    }
}
