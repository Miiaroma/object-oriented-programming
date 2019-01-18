using System;

namespace Employee_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa työntekijöiden tiedot ja vertailee palkkoja\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Matti", "toimitusjohtaja", 5000);
            employees[1] = new Employee("Maija", "myyntipäällikkö", 3500);
            employees[2] = new Employee("Pekka", "suunnittelija", 3000);


            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine(employees[0].CompareSalary(employees[1]));
            Console.WriteLine(employees[0].CompareSalary(employees[2]));
            Console.WriteLine(employees[2].CompareSalary(employees[1]));

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
