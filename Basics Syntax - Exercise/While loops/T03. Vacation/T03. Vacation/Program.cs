using System;

namespace T03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string input; //spend/save
            double money; // an amount that only saves ot spend

            int daysCount = 0;
            int spendCount = 0;

            while (availableMoney < needMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                daysCount++; // increases the counter of the days

                if (input == "spend")
                {
                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                    spendCount++;
                    if (spendCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    availableMoney += money;
                    spendCount = 0;

                }
            }

            if (availableMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
        }
    }
}
