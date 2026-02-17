using Movie_Ticket_Booking_System.Enums;
using Movie_Ticket_Booking_System.Structs;
using System.Diagnostics.Metrics;

namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            TicketType ticketType;
            SeatLocation seatLocation;
            char seatRow;
            int seatNumber;
            double price;
            double discount;
            Ticket ticket;
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): : ");
            ticketType = (TicketType)Enum.Parse(typeof(TicketType), Console.ReadLine());

            Console.Write("Enter Seat Row (A, B, C...): ");
            seatRow = char.Parse(Console.ReadLine()); //Test

            Console.Write("Enter Seat Number: ");
            int.TryParse(Console.ReadLine(), out seatNumber);

            Console.Write("Enter Price: ");
            double.TryParse(Console.ReadLine(), out price);

            Console.Write("Enter Discount Amount: ");
            double.TryParse(Console.ReadLine(), out discount);

            seatLocation = new SeatLocation { Row = seatRow, Number = seatNumber };
            ticket = new Ticket(movieName, seatLocation, price, ticketType, discount);

            Console.WriteLine("\n===== Ticket Info =====");

            ticket.PrintTicket();

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before\t: {ticket.Discount}");
            ticket.ApplyDiscount();
            Console.WriteLine($"Discount After\t: {ticket.Discount}");
            Console.WriteLine($"Movie\t: {ticket.MovieName}");
            Console.WriteLine($"Type\t: {ticket.Type}");

        }
    }
}
