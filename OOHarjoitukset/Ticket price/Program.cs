using System;

namespace Ticket_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;            

            Console.WriteLine("Ohjelma laskee maatalousnäyttelyn lipun hinnan\n");
            Console.Write(" 1 = Aikuinen, 2 = Opiskelija, 3 = MTK:n jäsen, 4 - Opiskelija ja MTK:n jäsen," +
            " 5 = Varusmies, Eläkeläinen (65 v. tai yli) tai Lapsi (7 - 15 v.), 6 = Lapsi (alle 7 v.) ");
            
            Ticket ticket = new Ticket();
            ticket.AskData();
            ticket.CountPrice();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
