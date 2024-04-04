using System;
using System.Globalization;
using System.Collections.Generic;

namespace MeuPrograma
{
    // Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
    // N funcionários. Não deve haver repetição de id.
    // Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
    // Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
    // mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
    // conforme exemplos.
    // Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
    // ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
    // aumento por porcentagem dada.
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }
        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Salary;
        }
    }
    class Programa
    {
        static void Main(string[] args)
        {   

            List<Employee> list = new List<Employee>();
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i}:", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchid = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchid);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(pct);
            }
            else {
                Console.WriteLine("This id does not exist! ");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}