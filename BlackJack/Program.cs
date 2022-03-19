using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать.");
            Console.Write("\nУкажите количество карт, которые имеются у Вас на руках: ");
            int CountCard = int.Parse(Console.ReadLine());
            int summ = 0;

            Console.WriteLine("\nВалет - J, Дама - Q, Король - K, Туз - T\n");

            for (int i = 0; i < CountCard; i++)
            {
                Console.Write("Введите номинал карты: ");
                string NominalCard = Console.ReadLine().ToUpper();
                switch (NominalCard)
                {
                    case "1":
                        summ += 1;
                        break;
                    case "2":
                        summ += 2;
                        break;
                    case "3":
                        summ += 3;
                        break;
                    case "4":
                        summ += 4;
                        break;
                    case "5":
                        summ += 5;
                        break;
                    case "6":
                        summ += 6;
                        break;
                    case "7":
                        summ += 7;
                        break;
                    case "8":
                        summ += 8;
                        break;
                    case "9":
                        summ += 9;
                        break;
                    case "10":
                        summ += 10;
                        break;
                    case "J":
                        summ += 10;
                        break;
                    case "Q":
                        summ += 10;
                        break;
                    case "K":
                        summ += 10;
                        break;
                    case "T":
                        summ += 11;
                        break;
                }
            }
            Console.WriteLine($"\nСумма карт состовляет: {summ}");

            Console.ReadKey();
        }
    }
}
