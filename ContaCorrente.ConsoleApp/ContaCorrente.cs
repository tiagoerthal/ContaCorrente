using System;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public string[] historicoDeMovimentacao = new string[10]; // inicializado aqui
        public int contadorHistorico;
        public int numeroConta;
        public int limite;
        public double saldo;

        public static ContaCorrente CriarConta(int numero, int limiteInicial)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.numeroConta = numero;
            conta.limite = limiteInicial;
            conta.saldo = 0;
            // Não precisa mais inicializar o array aqui
            conta.contadorHistorico = 0;
            return conta;
        }

        public void ObterSaque(double valor)
        {
            if (saldo <= 0 || valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            saldo -= valor;
            string mensagem = $"Saque de R${valor:F2} realizado";
            historicoDeMovimentacao[contadorHistorico] = mensagem;
            contadorHistorico++;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Depósito inválido, valor: {valor}");
                return;
            }

            saldo += valor;
            string mensagem = $"Depósito de R${valor:F2} realizado";
            historicoDeMovimentacao[contadorHistorico] = mensagem;
            contadorHistorico++;
        }

        public void ObterSaldo()
        {
            Console.WriteLine($"Conta: {numeroConta}, Saldo: R${saldo:F2}");
        }

        public void Transferir(ContaCorrente contaFim, double valor)
        {
            if (saldo <= 0 || saldo < valor || valor <= 0)
            {
                Console.WriteLine($"Fundos insuficientes, valor: {valor}");
                return;
            }

            if (contaFim.numeroConta == numeroConta)
            {
                Console.WriteLine("Incapaz de transferir para a mesma conta");
                return;
            }

            saldo -= valor;
            contaFim.saldo += valor;

            string msgOrigem = $"Transferência de R${valor:F2} para conta {contaFim.numeroConta}";
            string msgDestino = $"Transferência de R${valor:F2} recebida da conta {numeroConta}";

            historicoDeMovimentacao[contadorHistorico++] = msgOrigem;
            contaFim.historicoDeMovimentacao[contaFim.contadorHistorico++] = msgDestino;

            Console.WriteLine(msgOrigem);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da conta {numeroConta}:");

            for (int i = 0; i < contadorHistorico; i++)
            {
                if (!string.IsNullOrEmpty(historicoDeMovimentacao[i]))
                {
                    Console.WriteLine($" - {historicoDeMovimentacao[i]}");
                }
            }
        }
    }
}
