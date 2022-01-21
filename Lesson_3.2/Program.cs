using System;

namespace Lesson_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("Приветствую игрок!\nСколько у вас карт?");
            int cards = int.Parse(Console.ReadLine());
            for (int i = 0; i < cards; i++)
            {
                Console.WriteLine($"Введите номинал {i + 1}-й карты");
                switch (Console.ReadLine())
                {
                    case "1":
                        Sum += 1;
                        break;
                    case "2":
                        Sum += 2;
                        break;
                    case "3":
                        Sum += 3;
                        break;
                    case "4":
                        Sum += 4;
                        break;
                    case "5":
                        Sum += 5;
                        break;
                    case "6":
                        Sum += 6;
                        break;
                    case "7":
                        Sum += 7;
                        break;
                    case "8":
                        Sum += 8;
                        break;
                    case "9":
                        Sum += 9;
                        break;
                    case "10":
                        Sum += 10;
                        break;
                    case "J":
                        Sum += 10;
                        break;
                    case "Q":
                        Sum += 10;
                        break;
                    case "K":
                        Sum += 10;
                        break;
                    case "T":
                        Sum += 10;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Сумма карт: {Sum}");
            Console.ReadKey();
        }
    }
}
