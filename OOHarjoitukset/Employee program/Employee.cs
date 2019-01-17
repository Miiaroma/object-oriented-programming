using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_program
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;

        public Employee()
        {
            this.name = String.Empty; 
            this.id = String.Empty; 
            this.position = String.Empty;
            this.salary = 0;
        }

        public Employee(string name, string id, string position, int salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public string CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on suurempi kuin työntekijän {employee.name} palkka {employee.salary} €.";
            }

            if (this.salary == employee.salary)
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on yhtä suuri kuin työntekijän {employee.name} palkka {employee.salary} €.";

            }
            else
            {
                return $"Työntekijän {this.name} palkkaa {this.salary} € on pienempi kuin työntekijän {employee.name} palkka {employee.salary} €.";
            }
        }

        public override string ToString()
        {
            return $"Työntekijän nimi: {name}\ntunnus: {id}\ntehtävä: {position}\npalkka: {salary} €\n";
        }
    }
}