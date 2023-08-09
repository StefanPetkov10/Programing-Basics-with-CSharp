using System;

namespace T05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double chageToReturn = double.Parse(Console.ReadLine());
            chageToReturn *= 100; // to make the task easier
            int count = 0;

            while (chageToReturn > 0)
            {
                if (chageToReturn >= 200)
                {
                    count++;
                    chageToReturn -= 200;
                }
                else if (chageToReturn >= 100)
                {
                    count++;
                    chageToReturn -= 100;
                }
                else if (chageToReturn >= 50)
                {
                    count++;
                    chageToReturn -= 50;
                }
                else if (chageToReturn >= 20)
                {
                    count++;
                    chageToReturn -= 20;
                }
                else if (chageToReturn >= 10)
                {
                    count++;
                    chageToReturn -= 10;
                }
                else if (chageToReturn >= 5)
                {
                    count++;
                    chageToReturn -= 5;
                }
                else if (chageToReturn >= 2)
                {
                    count++;
                    chageToReturn -= 2;
                }
                else if (chageToReturn >= 1)
                {
                    count++;
                    chageToReturn -= 1;
                }
                else
                {
                    chageToReturn = 0;
                }
            }
            Console.WriteLine(count);
        }
    }   
}
    
        
    

 