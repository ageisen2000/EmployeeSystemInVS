using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class SalaryEmployee : Employee
    {
        protected double sal; 
        private double Salary { get { return sal; } set { sal = value; } }

        public SalaryEmployee(string fn, string ln, int empN, double sala):base(fn,ln,empN)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empN;
            Salary = sala;
        }
      
        public override double calculateMonthlyPay()
        {
            return Salary / 12;
        }
        public bool Equal(Employee e, Employee f)
        {
            if ((e.EmployeeNumber == f.EmployeeNumber) && (e.GetType() == f.GetType())) {
                return true;
            }
            return false;
        }
        public override void calculateYearlyPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            String output;
            output = "Salary Employee: " + employeeNumber + " " + "Name: " + firstName + " " + lastName + " Salary: $" + calculateMonthlyPay();
            return output;
        }
    }
}
