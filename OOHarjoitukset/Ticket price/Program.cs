using System;

namespace Ticket_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee maatalousnäyttelyn lipun hinnan\n");
            Console.WriteLine("Lippuvaihtoehdot:\n" +
                            "1 = Aikuinen\n" +
                            "2 = Opiskelija\n" +
                            "3 = MTK:n jäsen\n" +
                            "4 = Opiskelija ja MTK:n jäsen\n" +
                            "5 = Varusmies, eläkeläinen (65 v. tai yli) tai lapsi (7 - 15 v.)\n" +
                            "6 = Lapsi (alle 7 v.)\n");

            Ticket ticket = new Ticket();
            ticket.AskData();
            ticket.CountPrice();

            //Ticket ticket2 = new Ticket();
            //ticket2.AskData();
            //ticket2.CountPrice();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
