using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_program
{
    class Employee
    {
        public string name;       
        public int id;
        private static int counter = 1;
        public string position;
        public double salary;

        public Employee()
        {
            this.name = String.Empty; 
            this.id = counter++;

            this.position = String.Empty;
            this.salary = 0;
        }

        public Employee(string name, int id, string position, int salary)
        {
            this.name = name;
            this.id = counter++;
            this.position = position;
            this.salary = salary;
        }

        public string CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on suurempi kuin työntekijän {employee.name} palkka {employee.salary} €.\n";
            }

            if (this.salary == employee.salary)
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on yhtä suuri kuin työntekijän {employee.name} palkka {employee.salary} €.\n";

            }
            else
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on pienempi kuin työntekijän {employee.name} palkka {employee.salary} €.\n";
            }
        }

        public override string ToString()
        {
            return $"Työntekijän nimi: {name}\ntunnus: {id}\ntehtävä: {position}\npalkka: {salary} €\n";
        }
    }
}