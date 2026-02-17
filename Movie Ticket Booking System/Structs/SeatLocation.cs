using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System.Structs
{
    internal struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
    }
}
