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
            Console.WriteLine("Добро пожаловать в игру \"Black Jack\".");
            Console.Write("\nУкажите количество карт, которые имеются у Вас на руках: ");
            int CountCard = int.Parse(Console.ReadLine());
            int summ = 0;

            Console.WriteLine("\nВалет - J, Дама - Q, Король - K, Туз - T\n");

            for (int i = 0; i < CountCard; i++)
            {
                Console.Write($"Введите номинал {i+1} карты: ");
                string NominalCard = Console.ReadLine().ToUpper();

                bool IsNumber = int.TryParse(NominalCard, out int result);
                if (IsNumber == true && int.Parse(NominalCard) <= 10)
                {
                    int NumberNominalCard = Convert.ToInt32(NominalCard);
                    summ += NumberNominalCard;
                }

                switch (NominalCard)
                {
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
