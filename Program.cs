using System;

namespace pr8
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.Title = "Практическая работа №8-1";
            double n, p, s;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Здравствуйте!");

            try
            {
                Console.Write("Введите стартовый капитал (n): ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ежемесячный рост дохода в процентах (p): ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целевую сумму (s): ");
                s = Convert.ToDouble(Console.ReadLine());

                double sum = 0;
                double d = n;
                int m = 0;
                int max = 10000;

                while (m < max)
                {
                    m++;
                    sum += d;
                    if (sum >= s)
                    {
                        break;
                    }
                    d = d * (1 + p / 100);
                }

                double year = (double)m / 12.0;
                Console.WriteLine($"Даня М. сможет отправиться в тур через {(Math.Round(year, 1))} лет.");
            }
            
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nЧто-то пошло не так. Ошибка: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}

