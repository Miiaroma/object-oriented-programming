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
            Console.WriteLine("Valitse lippu, syötä numero: ");
            string ticketValue = Console.ReadLine();

            int.TryParse(ticketValue, out ticket);
        }

        public void CountPrice()
        {
            if (ticket == 1)
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * discount:f2} €.");
            else if (ticket == 6)
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * 1.00:f2} €.");
            else if (ticket == 2)
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * 0.15:f2} €.");
            else if (ticket == 3)
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * 0.45:f2} €.");
            else if (ticket == 4)
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * 0.60:f2} €.");
            else
                Console.WriteLine($"Lipun hinta on {this.ticketPrice - this.ticketPrice * 0.50:f2} €.");
        }
    }
}

