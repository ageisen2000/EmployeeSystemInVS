using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    abstract class Employee
    {
        /* Some variables for employee */
        protected string firstName;
        protected string lastName;
        protected int employeeNumber;
        protected double monthlyPay;
        protected double yearlyPay;
        
        /* Abstract methods needing to be overridden */
        public abstract double calculateMonthlyPay();
        public abstract double calculateYearlyPay();

        /* getters and setters */
        public string FirstName {
            get { return firstName; }
            set {
                if (value.Length > 15)
                {
                    Console.WriteLine("Invalid First Name. Too long");
                    Console.WriteLine("Defaulting to \"Invalid\"");
                    firstName = "invalid";
                }else if ( value.Length <= 0)
                {
                    Console.WriteLine("Invalid Name. Defaulting to \"Invalid\"");
                    firstName = "Invalid";
                }
                firstName = value;
            }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public int EmployeeNumber {
            get { return employeeNumber;
            }
            set { employeeNumber = value; }
        }
            
        /* Employee constructor */
        public Employee(string fn, string ln, int empNum)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empNum;
        }
        /* I needed to override this for the Equal method
         * TODO revisit this                               */
        public override int GetHashCode()
        {
            return EmployeeNumber;
        }
    }
}
