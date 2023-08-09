using System;

namespace T06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int sizeCake = length * width;
            string input = Console.ReadLine();
            int piecesOfCake = 0;

            while (input != "STOP")
            {
                piecesOfCake += int.Parse(input);

                if (piecesOfCake > sizeCake)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (piecesOfCake > sizeCake)
            {
                Console.WriteLine($"No more cake left! You need {piecesOfCake - sizeCake} pieces more.");
            }
            else
            {
                Console.WriteLine($"{sizeCake - piecesOfCake} pieces are left.");
            }
        }
    }
}
