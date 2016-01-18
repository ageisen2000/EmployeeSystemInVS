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
            /* do the program */
            Company company = new Company();
            doIt(company);

            /* Pause the program so the console doesnt close itself 
             Yeah Yeah... I know visual studio can be set up correctly,
             but that's no fun */
            Pause();
        }

        static void doIt(Company company)
        {
            /* Some variables */
            String input;
            int choice = 0;
            while (choice != 9) 
            {
                /* Print the welcome message */
                printWelcome();
                try
                {
                    /* Going to need some error handling here */
                    input = Console.ReadLine();
                    choice = int.Parse(input);

                    /* Process the user choice */
                    switch (choice)
                    {
                        case 1:
                            HourlyInput(company);
                            break;
                        case 2:
                            SalaryInput(company);
                            break;
                        case 3:
                            company.printHourly();
                            break;
                        case 4:
                            company.printSalary();
                            break;
                        case 5:
                            company.printAll();
                            break;
                        case 6:
                            Console.Write("How many?: ");

                            /* Adds Random Hourly Employees */
                            AddRandomHourly(int.Parse(Console.ReadLine()), company);
                            break;
                        case 7:
                            /* Adds Random Salary Employees */
                            AddRandomSalary(int.Parse(Console.ReadLine()), company);
                            break;
                        case 9:
                            break;
                        default:
                            /* TODO revisit this */
                            choice = 0;
                            Console.WriteLine("Invalid entry. Restarting...");
                            break;
                    }
                }

                /* catch all exceptions */
                catch (Exception x) {
                    Console.WriteLine("***--------------ERROR--------------***");
                    Console.WriteLine(x.Message);
                    Console.WriteLine("Try again...");
                };
            }
        }

        /* Visual Studio auto-closes the console window if I don't put this */
        static void Pause()
        {
            Console.Write("\nPress enter to close...");
            Console.Read();
        }

        /* 
           Add a random hourly employee, takes a number of 
           employees to add, as well as the company list 
        */
        /* Random variable for the 2 employee types */

        static Random _r = new Random();
        static void AddRandomHourly(int count, Company company)
        {
            Employee e;

            /* set some values for creating the employees */
            int empNum = 0;
            double hours = 0;
            double moneyPerHour = 0;

            /* loop to add them */
            for (int i = 0; i < count; i++)
            {

                //empNum = _r.Next(100000, 999999);
                //moneyPerHour = _r.Next(8, 50);
                //hours = _r.Next(20, 40);
                /* create new employee */
                //e = new HourlyEmployee("FN" + i, "LN" + i, empNum, moneyPerHour, hours);
                e = new HourlyEmployee("FN" + i, "LN" + i, i, i, i);
                /* this adds employee to the company */
                company.addEmployee(e);
            }
        }

        /* 
            Add a random salary employee, takes a number of 
            employees to add, as well as the company list 
        */
        static void AddRandomSalary(int count, Company company)
        {
            Employee e;

            /* set some values for creating the employees */
            double salary = _r.Next(50000,100000);
            int empId = _r.Next(100000,999999);

            /* loop to add them */
            for (int i = 0; i < count; i++)
            {
                e = new SalaryEmployee("FN" + i, "LN" + i, empId, salary);
                company.addEmployee(e);
            }
        }

        /* Prints the welcome message */
        static void printWelcome()
        {
            Console.WriteLine("\nWelcome to the Employee System.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Add an Hourly Employee\n"
                + "2) Add a Salary Employee\n"
                + "3) Print Hourly Employees\n"
                + "4) Print Salary Employees\n"
                + "5) Print All Employees\n"
                + "6) Add a number of random Hourly Employees\n"
                + "7) Add a number of random Salary Employees\n"
                + "9) Exit the application\n"
                );
            Console.Write("Choice: ");
        }

        static void SalaryInput(Company company)
        {
            /* Input Variables */
            Employee e;
            String input;
            String iFirstName = "";
            String iLastName = "";
            int iEmployeeNumber = -1;
            double iSalary = -1;
            
            /* TODO Error checking!! */
            Console.Write("Enter First Name: ");
            input = Console.ReadLine();
            iFirstName = input;
            /* TODO Error checking!! */
            Console.Write("Enter Last Name: ");
            input = Console.ReadLine();
            iLastName = input;
            /* TODO Error checking!! */
            Console.Write("Enter Employee Number: ");
            input = Console.ReadLine();
            iEmployeeNumber = int.Parse(input);
            /* TODO Error checking!! */
            Console.Write("Enter Salary: $");
            input = Console.ReadLine();
            iSalary = int.Parse(input);
            e = new SalaryEmployee(iFirstName, iLastName, iEmployeeNumber, iSalary);
            company.addEmployee(e);
        }
        static void HourlyInput(Company company)
        {
            /* Input Variables */
            Employee e;
            String input;
            String iFirstName = "";
            String iLastName = "";
            int iEmployeeNumber = -1;
            double iDollarsPerHour = -1;
            double iHours = -1;

            /* TODO Error checking!! */
            Console.Write("Enter First Name: ");
            input = Console.ReadLine();
            iFirstName = input;
            /* TODO Error checking!! */
            Console.Write("Enter Last Name: ");
            input = Console.ReadLine();
            iLastName = input;
            /* TODO Error checking!! */
            Console.Write("Enter Employee Number: ");
            input = Console.ReadLine();
            iEmployeeNumber = int.Parse(input);
            /* TODO Error checking!! */
            Console.Write("Enter Dollars Per Hour: $");
            input = Console.ReadLine();
            iDollarsPerHour = double.Parse(input);
            /* TODO Error checking!! */
            Console.Write("Enter Number of Hours Worked: ");
            input = Console.ReadLine();
            iHours = double.Parse(input);
            e = new HourlyEmployee(iFirstName, iLastName, iEmployeeNumber, iDollarsPerHour, iHours);
            company.addEmployee(e);
        }
    }
}
