using System;
using System.Text;

namespace SoftwareProducts
{
    class Program
    {
        // Оголошення перерахування
        enum Products
        {
            // 1-а, 2-га та 3-тя система автоматизації
            System1_Automation =1,
            System2_Automation,
            System3_Automation,
            // 1-а, 2-га та 3-тя система для управління логістикою
            System1_Logistics,
            System2_Logistics,
            System3_Logistics
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string answer;

            do
            {
                // Виведення на екран списку доступних програмних продуктів
                Console.WriteLine("List of available software products:");
                Console.WriteLine("{0} - {1}", (int)Products.System1_Automation, Products.System1_Automation.ToString());
                Console.WriteLine("{0} - {1}", (int)Products.System2_Automation, Products.System2_Automation.ToString());
                Console.WriteLine("{0} - {1}", (int)Products.System3_Automation, Products.System3_Automation.ToString());
                Console.WriteLine("{0} - {1}", (int)Products.System1_Logistics, Products.System1_Logistics.ToString());
                Console.WriteLine("{0} - {1}", (int)Products.System2_Logistics, Products.System2_Logistics.ToString());
                Console.WriteLine("{0} - {1}", (int)Products.System3_Logistics, Products.System3_Logistics.ToString());

                // Запит на введення номерів програмних продуктів, які користувач хоче придбати
                Console.Write("Enter the numbers of the software products you want to buy: ");
                string input = Console.ReadLine();
                string[] selectedProducts = input.Split(',');

                Console.WriteLine("Бугайчук Андрій");

                // Виведення списку обраних програмних продуктів з категорії автоматизації
                Console.WriteLine("Automation systems:");
                foreach (string selectedProduct in selectedProducts)
                {
                    int productNumber = int.Parse(selectedProduct.Trim());
                    if (productNumber >= (int)Products.System1_Automation && productNumber <= (int)Products.System3_Automation)
                    {
                        Console.WriteLine("- {0}", (Products)productNumber);
                    }
                }

                // Виведення списку обраних програмних продуктів з категорії логістики
                Console.WriteLine("Logistics systems:");
                foreach (string selectedProduct in selectedProducts)
                {
                    int productNumber = int.Parse(selectedProduct.Trim());
                    if (productNumber >= (int)Products.System1_Logistics && productNumber <= (int)Products.System3_Logistics)
                    {
                        Console.WriteLine("- {0}", (Products)productNumber);
                    }
                }

                // Перевірка на бажання продовжити виконання операцій
                Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y");
        }
    }
}
