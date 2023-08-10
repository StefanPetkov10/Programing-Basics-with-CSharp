using System;

namespace T08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTurnaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int pointsTurnament = 0;
            string stage = string.Empty;
            double pointsAverage = 0;
            double perecent = 0;
            double numW = 0;

            for (int i = 1; i <= numTurnaments; i++)
            {
                stage = Console.ReadLine();

                if (stage == "W")
                {
                    pointsTurnament += 2000;
                    numW++;
                }
                else if (stage == "F")
                {
                    pointsTurnament += 1200;
                }
                else if (stage == "SF")
                {
                    pointsTurnament += 720;
                }
                pointsAverage = pointsTurnament / numTurnaments;
                
            }
            Console.WriteLine($"Final points: {points + pointsTurnament}");
            Console.WriteLine($"Average points: {(pointsAverage)}");
            perecent = numW / numTurnaments * 100;
            Console.WriteLine($"{perecent:f2}%");       
        }
    }
}
