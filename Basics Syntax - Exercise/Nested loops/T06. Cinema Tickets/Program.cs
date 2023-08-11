using System;

namespace T06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            int saleTickets = 0;

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int saleTicketsForProjection = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End" )
                {
                    saleTickets++;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else 
                    {
                        kidTickets++;
                    }
                    saleTicketsForProjection++;
                    

                    if (freeSeats == saleTicketsForProjection)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }
              

                double occupancy = saleTicketsForProjection * 100.0 / freeSeats;
                Console.WriteLine($"{input} - {occupancy:f2}% full.");

                input = Console.ReadLine();

            }
            Console.WriteLine($"Total tickets: {saleTickets}");
            Console.WriteLine($"{studentTickets * 100.0 / saleTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / saleTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / saleTickets:f2}% kids tickets.");
        }
    }
}
