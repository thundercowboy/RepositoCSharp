
using Course.Entities;

namespace MeuPrograma
{
    class Programa
    {
        static void Main(string[] args)
        {   
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Alex", 0.0, 500.0);
            SavingsAccount acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(account);
        }
    }
}