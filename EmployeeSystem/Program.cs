using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /* instantiate an employee object */
            Employee e;
            Random r = new Random();
            /* set some values for creating the employees */
            double between;
            double high = 999999;
            double low = 100000;
            Company company = new Company();
            /* Add a bunch of hourly employees to the company list*/
            double hours;
            double moneyPerHour;
            /* loop to add them */
            for (int i = 0; i < 10; i++)
            {
                /* these values are only used for the constructor
                 * and are random every time                        */
                moneyPerHour = ((6 + i) * r.NextDouble());
                hours = ((10 + i) * r.NextDouble());
                between = (r.NextDouble() * (high - low)) + low;
                /* this makes the new employee */
                e = new HourlyEmployee("FN" + i, "LN" + i, (int)between, moneyPerHour, hours);
                /* this adds employee to the company */
                company.addEmployee(e);
            }
            /* add a bunch of Salary Employees to the company list */

            double salary;

            /* loop to add them */
            for (int i = 0; i < 10; i++)
            {
                salary = ((40000 + i) * r.NextDouble());
                between = (r.NextDouble() * (high - low)) + low;
                e = new SalaryEmployee("FN" + i, "LN" + i, (int)between, salary);
                company.addEmployee(e);
            }

            /* print em out */
            //company.printSalary();
            //company.printHourly();
            company.printAll();

            /* do this so visual studio doesnt automatically close */
            Console.Write("\nPress enter to close...");
            Console.Read();
        } 
    }
}
