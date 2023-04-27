using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_1
{
    internal class P3_1
    {
        static void Main()
        {
            bool correct = false;

            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] date;
            int nom = 0;
            int ost = 0;
            int year = 365;

            do
            {
                string[] D = Console.ReadLine().Split(' ');

                date = Array.ConvertAll(D, s => int.Parse(s));

                if ((date[2] % 4 == 0 & date[2] % 100 != 0) | date[2] % 400 == 0)
                {
                    days[1] = days[1] + 1;
                    year += 1;
                }
                if ((date[1] <= 12) & (date[0] <= days[date[1]-1]))
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("неправильная дата");
                }

            }
            while (correct == false);

            for(int i = 0; i < date[1]-1; i++) 
            {
                nom = nom + days[i];
            }
            nom += date[0];

            Console.WriteLine($"Номер дня с начала года: {nom}");

            ost = year-nom-1;

            Console.WriteLine($"До конца года осталось: {ost}");

            Console.ReadKey();
        }
    }
}