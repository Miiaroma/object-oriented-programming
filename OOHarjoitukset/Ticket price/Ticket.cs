using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_price
{
    class Ticket
    {
        public int ticketPrice;
        public double discount;
        public int ticket;

        public Ticket()
        {
            this.ticketPrice = 16;
            this.discount = 0;           
        }

        public Ticket(int ticketPrice, double discount)
        {
            this.ticketPrice = ticketPrice;
            this.discount = discount;
        }

        public void AskData()
        {
            Console.WriteLine("Anna lipputyypin numero: ");
            string ticketValue = Console.ReadLine();

            int.TryParse(ticketValue, out ticket);
        }

        public void CountPrice()
        {
            if (ticket == 1)
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * discount} €");
            else if (ticket == 6)
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * 1.00} €");
            else if (ticket == 2)
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * 0.15} €");
            else if (ticket == 3)
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * 0.45} €");
            else if (ticket == 4)
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * 0.60} €");
            else
                Console.WriteLine($"Lipun hintasi on {this.ticketPrice - this.ticketPrice * 0.50} €");
        }
    }
}

