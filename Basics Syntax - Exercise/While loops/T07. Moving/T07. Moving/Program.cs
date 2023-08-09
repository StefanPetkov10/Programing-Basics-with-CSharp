using System;

namespace T07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int volume = width * length * hight;
            string input = (Console.ReadLine());
            int numberBoxes = 0;

            while (input != "Done")
            {
                numberBoxes += int.Parse(input);

                if (numberBoxes >= volume)
                {
                    break;
                }
                if (input == "Done")
                {
                    break;
                }
                input = Console.ReadLine();

            }
            if (numberBoxes > volume)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume - numberBoxes)} Cubic meters more.");
            }
            else
            {               
                Console.WriteLine($"{volume - numberBoxes} Cubic meters left.");
            }
        }
    }
}

