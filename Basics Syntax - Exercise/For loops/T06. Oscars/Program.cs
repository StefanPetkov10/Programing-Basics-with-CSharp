using System;

namespace T06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string assessorName = string.Empty;
            double assessorPoints = 0;

            for (int i = 0; i < n; i++)
            {

                assessorName = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());

                points += assessorName.Length * assessorPoints / 2;

                if (points >= 1250.5)
                {
                    break;
                }
            }
            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {(points):f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - points):f1} more!");
            }
        }
    }
}
