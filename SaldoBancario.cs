using System;
using System.Globalization;

namespace MeuPrograma
{
    class Programa
    {
        static void Main(string[] args)
        {  
            
           ContaBancaria conta;

           Console.Write("Entre o número da sua conta: ");
           int numeroconta = int.Parse(Console.ReadLine()); 
           Console.Write("Entre o titular da conta: ");
           string nometitular = Console.ReadLine();
           Console.Write("Haverá depósito inicial (s/n)? ");
           char resp = char.Parse(Console.ReadLine());
           if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double saldoinput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroconta, nometitular, saldoinput);
           }
           else {
                conta = new ContaBancaria(numeroconta, nometitular);
           }

           Console.WriteLine();
           Console.WriteLine("Dados da Conta: ");
           Console.Write(conta);
           
           Console.WriteLine();
           Console.Write("Entre um valor para depósito: ");
           double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           conta.Deposito(qtd);
           Console.WriteLine("Dados da conta atualizados:");
           Console.WriteLine(conta);

           Console.WriteLine();
           Console.Write("Entre um valor para saque: ");
           qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           conta.Saque(qtd);
           Console.WriteLine("Dados da conta atualizados:");
           Console.WriteLine(conta);
        }
    }
    class ContaBancaria {
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        public ContaBancaria(int numeroconta, string nometitular) {
            NumConta = numeroconta;
            NomeTitular = nometitular;
        }
        public ContaBancaria(int numeroconta, string nometitular, double saldo) : this(numeroconta, nometitular) {
            Saldo = saldo;
        }
        public void Deposito(double quantidade) {
            Saldo += quantidade;
        }
        public void Saque(double quantidade) {
            Saldo -= quantidade + 5.0;
        }
        public override string ToString()
        {
            return "Conta " 
            + NumConta
            + ", Titular: "
            + NomeTitular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}