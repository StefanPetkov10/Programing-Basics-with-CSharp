using System;

namespace T01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFavoritBook = Console.ReadLine();
            int count = 0;

            string inputBook = Console.ReadLine();


            while(inputBook != "No More Books")
            {
                if (inputBook == inputFavoritBook)
                {
                    break;
                }
                count++;

                inputBook = Console.ReadLine();
            }
            if (inputBook == inputFavoritBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
