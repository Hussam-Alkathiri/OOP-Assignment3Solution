using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Ticket_Booking_System
{
    internal class Ticket
    {
        public Ticket(string eventName, string seatNumber, TicketType type)
        {
            EventName = eventName;
            SeatNumber = seatNumber;
            Type = type;
        }

        public string EventName { get; set; }
        public string SeatNumber { get; set; }
        public TicketType Type { get; set; }
        public override string ToString()
        {
            return $"Event: {EventName}, Seat: {SeatNumber}, Type: {Type}";
        }



    }
}
