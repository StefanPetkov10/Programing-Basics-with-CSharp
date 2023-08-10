using System;

namespace T03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumber = int.Parse(Console.ReadLine());

            double p1 = 0; // <200
            double p2 = 0; // >=200 && <=399
            double p3 = 0; // >=400 && <=599
            double p4 = 0; // >=600 && <=799
            double p5 = 0; // >=800

            int num = 0;

            for (int count = 0; count < countOfNumber; count++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }
            p1 = p1 / countOfNumber * 100;
            p2 = p2 / countOfNumber * 100;
            p3 = p3 / countOfNumber * 100;
            p4 = p4 / countOfNumber * 100;
            p5 = p5 / countOfNumber * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
