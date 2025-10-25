using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Ticket_Booking_System
{
    internal class TicketSystem
    {
        private List<Ticket> tickets = new List<Ticket>();

        
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        
        public Ticket this[string seatNumber]
        {
            get
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.SeatNumber == seatNumber)
                        return ticket;
                }
                return null;
            }
        }
        public void CountTicketsByType()
        {
            int regularCount = 0, vipCount = 0, backstageCount = 0;

            foreach (Ticket ticket in tickets)
            {
                {
                    switch (ticket.Type)
                    {
                        case TicketType.Regular:
                            regularCount++;
                            break;
                        case TicketType.VIP:
                            vipCount++;
                            break;
                        case TicketType.Backstage:
                            backstageCount++;
                            break;

                    }
                }
            }
            Console.WriteLine("\n ______Ticket Indexer______");
            Console.WriteLine($"VIP Ticket : {vipCount}");
            Console.WriteLine($"Backstage Ticket : {backstageCount}");
        }
    }
}

