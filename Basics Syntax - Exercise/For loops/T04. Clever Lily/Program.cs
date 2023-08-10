using System;

namespace T04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyLv = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * 5 -1;
                   
                }
                else
                {
                    sum += toyLv;
                }
            }
            if (sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {sum - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(sum - washingMachine):f2}");
            }

        }
    }
}
