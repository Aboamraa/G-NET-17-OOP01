using Movie_Ticket_Booking_System.Enums;
using Movie_Ticket_Booking_System.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public SeatLocation Seat { get; set; }
        private double Price { get; set; }
        public TicketType Type { get; set; }
        public double? Discount { get; set; }

        public Ticket(string movieName, SeatLocation seat, double price, TicketType type, double? discount = 0)
        {
            MovieName = movieName;
            Seat = seat;
            Price = price;
            Type = type;
            Discount = discount;
        }
        public Ticket(string movieName) : this(movieName, new SeatLocation('A', 1), 50, TicketType.Standard)
        {
        }


        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }
        public double ApplyDiscount()
        {
            if (Discount > 0 || Discount <= Price)
            {
                Price -= Discount ?? 0;
                Discount = 0;
                return Price;
            }
            return Price;
        }
        public void PrintTicket()
        {
            Console.WriteLine(
                $"Movie\t: {MovieName}" +
                $"\nType\t: {Type}" +
                $"\nSeat\t: {Seat.Row}{Seat.Number}" +
                $"\nPrice\t: {Price}" +
                $"\nTotal (14% tax)\t: {CalcTotal(14)}"
                );
        }
        public override string ToString()
        {
            return $"Movie: {MovieName}, Seat: {Seat.Row}{Seat.Number}, Price: {Price}, Type: {Type}";
        }
    }
}
