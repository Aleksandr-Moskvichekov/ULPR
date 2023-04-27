using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3
{
    internal class Program
    {
        static void Main()
        {
            string R = "Y";
            while (R == "Y")
            {
                Console.WriteLine("Компьютер загадывает числа от 1 до 20, отгадайте его за 7 попыток");
                Random rnd = new Random();
                int num = rnd.Next(1, 20);

                bool win = false;
                Int16 n = 0;
                while (n != 7) {
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == num)
                    {
                        Console.WriteLine("Вы угадали");
                        n = 7;
                        win = true;
                    }
                    else
                    {
                        if (num2 > num)
                        {
                            Console.WriteLine("Меньше");
                            n += 1;
                        }
                        else
                        {
                            Console.WriteLine("Больше");
                            n += 1;
                        }
                    }
                }
                if (!win) { Console.WriteLine("Вы проиграли"); }
                R = "N";

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                R = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
