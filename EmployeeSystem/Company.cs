using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class Company
    {
        /* list of employees, otherwise known as the company */
        protected List<Employee> company = new List<Employee>();

        public Company()
        {
            /* do nothing here, however; could initialize a file to write to */
            /* or take a file as an argument to build a company from */
        }

        /* adds an employee to the company */
        public void addEmployee(Employee e)
        {
            company.Add(e);
        }

        /* prints out the hourly employees in the company list */
        public void printHourly()
        {
            System.Type type = typeof(HourlyEmployee);
            Console.WriteLine();
            Console.WriteLine("Hourly Employees");
            Console.WriteLine("--------------------------------------------------");
            foreach (Employee h in company)
            {
                if (h.GetType() == type)
                {
                    Console.WriteLine(h);
                }
            }
        }

        /* prints out the salary employees in the company list */
        public void printSalary()
        {
            System.Type type = typeof(SalaryEmployee);
            Console.WriteLine("Salary Employees");
            Console.WriteLine("--------------------------------------------------");
            foreach (Employee s in company)
            {
                if (s.GetType() == type)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void printAll()
        {
            printHourly();
            Console.WriteLine();
            printSalary();
        }
    }
}
