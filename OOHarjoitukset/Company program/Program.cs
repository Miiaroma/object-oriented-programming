using System;

namespace Company_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firmaluokka\n");

            Company firstComp = new Company("Firma Oy", "Katu 1", "010 123 4567", 1500000, 300000);
            Company secondComp = new Company("Yritys Oy", "Katu 2", "020 123 8901", 500000, 250000);
            Company thirdComp = new Company("Putiikki Oy", "Katu 3", "045 123 4567", 150000, 45000);
            Company fourthComp = new Company(firstComp);

            firstComp.PrintCompanyInfo();
            firstComp.Profit();

            secondComp.PrintCompanyInfo();
            secondComp.Profit();

            thirdComp.PrintCompanyInfo();
            thirdComp.Profit();

            fourthComp.PrintCompanyInfo();
            fourthComp.Profit();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
