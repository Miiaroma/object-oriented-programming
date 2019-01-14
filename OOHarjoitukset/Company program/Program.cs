using System;

namespace Company_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firmaluokka\n");

            Company firstComp = new Company("Firma", "Katu 1", "010 123 4567", 100000, 20000);
            Company secondComp = new Company("Yritys", "Katu 2", "020 123 8901", 500000, 200000);
            Company thirdComp = new Company(firstComp);

            firstComp.PrintCompanyInfo();
            firstComp.Profit();

            secondComp.PrintCompanyInfo();
            secondComp.Profit();

            thirdComp.PrintCompanyInfo();
            thirdComp.Profit();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
