using System;

namespace T07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumber = int.Parse(Console.ReadLine());

            double climbers1 = 0; // <=5
            double climbers2 = 0; // >=6 && <=12
            double climbers3 = 0; // >=13 && <=25
            double climbers4 = 0; // >=26 && <=40
            double climbers5 = 0; // >=41

            int num = 0;

            for (int count = 0; count < countOfNumber; count++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 6)
                {
                    climbers1 += num;
                }
                else if (num <= 12)
                {
                   climbers2 += num;
                }
                else if (num <= 25)
                {
                    climbers3 += num;
                }
                else if (num <= 40)
                {
                   climbers4 += num;
                }
                else if (num >= 41)
                {
                    climbers5+= num;
                }
            }
            double totalClimbers = climbers1 + climbers2 + climbers3 + climbers4 + climbers5;

            Console.WriteLine($"{climbers1 / totalClimbers * 100:f2}%");
            Console.WriteLine($"{climbers2 / totalClimbers * 100:f2}%");
            Console.WriteLine($"{climbers3 / totalClimbers * 100:f2}%");
            Console.WriteLine($"{climbers4 / totalClimbers * 100:f2}%");
            Console.WriteLine($"{climbers5 / totalClimbers * 100:f2}%");
        }
    }
}
