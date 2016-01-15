using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class HourlyEmployee : Employee
    {
        protected double dollarsperhour = 0;
        protected double hours = 0;

        public double DollarsPerHour { get { return dollarsperhour; }  set { dollarsperhour = value; } }
        public double Hours {
            get { return hours; }
            set { hours = value; }
        }

        public HourlyEmployee(string fn, string ln, int empN, double dph, double hr) : base(fn, ln, empN)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empN;
            DollarsPerHour = dph;
            Hours = hr;
        }

        public override double calculateMonthlyPay()
        {
            return DollarsPerHour * hours;
        }

        public bool Equals(Employee e, Employee f)
        {
            if(e.EmployeeNumber == f.EmployeeNumber)
            {
                return true;
            }
            return false;
        }

        public override double calculateYearlyPay()
        {
            yearlyPay = calculateMonthlyPay() * 12;
            return yearlyPay;
        }

        public override string ToString()
        {
            String output;
            output = "Hourly Employee: " + employeeNumber + "\t" + "Name: " + 
                     firstName + " " + lastName + " Pay: $" + calculateMonthlyPay();
            return output;
        }
    }
}

