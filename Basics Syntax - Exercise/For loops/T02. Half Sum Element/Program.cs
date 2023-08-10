using System;

namespace T02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int counter = 0; counter < counterOfNumber; counter++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            sum -= maxNum;
            if (maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int diff = Math.Abs(maxNum - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
