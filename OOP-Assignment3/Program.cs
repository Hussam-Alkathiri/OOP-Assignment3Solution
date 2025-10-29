using OOP_Assignment3.Model.Ticket_Booking_System;

namespace OOP_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketSystem system = new TicketSystem();

            system.AddTicket(new Ticket("Football Match", "A12",TicketType.VIP));
            system.AddTicket(new Ticket("Football Match", "A13", TicketType.Regular));
            system.AddTicket(new Ticket("Cinema show", "C09", TicketType.VIP));
            system.AddTicket(new Ticket("Power Olympiad", "B61", TicketType.Backstage));
            system.AddTicket(new Ticket("Formula One Racing", "D01", TicketType.VIP));
            
            Console.WriteLine("Accessing ticket with seat A13:");
            Ticket t = system["A13"];
            if (t != null)
                Console.WriteLine(t);
                else
                    Console.WriteLine("The Ticket not found.");
            system.CountTicketsByType();



        }
    }
}
