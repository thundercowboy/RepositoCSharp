
using System.Globalization;
using Course.Entities;

namespace MeuPrograma
{
    class Programa
    {
        static void Main(string[] args)
        {   
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ", n);
                Console.Write("Commom, used or imported (c/u/i): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}