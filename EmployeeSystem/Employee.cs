using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int employeeNumber;
        protected double monthlyPay;
        protected double yearlyPay;

        public abstract double calculateMonthlyPay();
        public abstract void calculateYearlyPay();
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int EmployeeNumber { get { return employeeNumber; } set { employeeNumber = value; } }
        public Employee(string fn, string ln, int empNum)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empNum;
        }
        public override int GetHashCode()
        {
            return EmployeeNumber;
        }
    }
}
