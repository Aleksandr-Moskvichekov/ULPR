using System;

class Sample
{
    public static void Main()
    {
       

        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int date = Convert.ToInt32(Console.ReadLine());

        
        if ((date % 4 == 0 & date % 100 != 0) | date % 400 == 0)
        {
            days[1] = 29;
        }

        for(int i=1; i < 13; i++)
        {
            for(int j=0; j < days[i-1]; j++)
            {
                DateTime dt = new DateTime(date, i, days[i - 1] - j);
                if (dt.DayOfWeek == DayOfWeek.Thursday)
                {
                    Console.WriteLine($"{days[i-1]-j}.{i}.{date}");
                    break;
                }
                
            }
        }
        Console.ReadKey();
    }
}

