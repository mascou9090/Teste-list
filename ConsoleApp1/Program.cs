using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("How many employees will be registered?");
            int employeeAux = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeAux; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Numero do id:");
                int idAux = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameAux = Console.ReadLine();
                Console.Write("Salary: ");
                double salaryAux = double.Parse(Console.ReadLine());

                employees.Add(new Employee(idAux, nameAux, salaryAux));
            };

            Console.WriteLine("Enter the employee id that will have salary increase :");
            int idEmployeeSearch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percentage: ");
            double percentAux = double.Parse(Console.ReadLine());


            int indexEmployee = employees.FindIndex(x => x.Id == idEmployeeSearch);

            if(indexEmployee != -1)
            {
                Employee employeChange = employees.Find(x => x.Id == idEmployeeSearch);

                int indexEmployeeRight = employees.FindIndex(x => x.Id == idEmployeeSearch);

                employeChange.IncreaseSalary(percentAux);

                employees.Insert(indexEmployeeRight, employeChange);
            } else
            {
                Console.WriteLine("This id doesn't exist!");
            }


            Console.WriteLine("Updated list of employees:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}