using System;
using System.Collections.Generic;
using System.Text;

namespace Company_program
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public int income;
        public int expenses;


        public Company()
        {
            this.title = "title";
            this.address = "address";
            this.phone = "phone";
            this.income = 0;
            this.expenses = 0;
        }

        public Company(string title, string address, string phone, int income, int expenses)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expenses = expenses;
        }

        public Company(Company prevCompany)
        {
            this.title = prevCompany.title;
            this.address = prevCompany.address;
            this.phone = prevCompany.phone;
            this.income = prevCompany.income;
            this.expenses = prevCompany.expenses;
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"Firman nimi: {this.title}");
            Console.WriteLine($"Osoite: {this.address}");
            Console.WriteLine($"Puhelin: {this.phone}");
            Console.WriteLine($"Tulot: {this.income}");
            Console.WriteLine($"Menot: {this.expenses}");
        }

        public void Profit()
        {
            double profit = 100 * (this.income - this.expenses) / this.expenses;
            Console.WriteLine($"Firman voitto-% on {profit}.");

            if (profit >= 300)
            {
                Console.WriteLine($"Firmalla menee hyvin.");
            }

            else if (profit >= 200 && profit < 300)
            {
                Console.WriteLine($"Firmalla menee tyydyttävästi.");
            }

            else if (profit >= 100 && profit < 200)
            {
                Console.WriteLine($"Firmalla menee välttävästi.");
            }

            else
            {
                Console.WriteLine($"Firmalla menee kehnosti.");
            }

            Console.WriteLine("------------------------------------");
        }
    }
}
                    
