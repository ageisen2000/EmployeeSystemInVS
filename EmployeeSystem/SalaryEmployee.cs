using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class SalaryEmployee : Employee
    {
        /*protected salary*/
        protected double sal; 
        /* getter and setter for the salary */
        /* TODO: Data validation */
        private double Salary {
            get { return sal; }
            set { sal = value; }
        }
        /* SalaryEmployee constructor */
        public SalaryEmployee(string fn, string ln, int empN, double sala):base(fn,ln,empN)
        {            
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empN;
            Salary = sala;
        }

        /* calculates monthly pay for the Salary employee */
        public override double calculateMonthlyPay()
        {
            return Salary / 12;
        }

        /* determines whether two employee objects are equal */
        /* TODO: revisit this                                */
        public bool Equal(Employee e, Employee f)
        {
            if ((e.EmployeeNumber == f.EmployeeNumber) && (e.GetType() == f.GetType())) {
                return true;
            }
            return false;
        }

        /* calculates the yearly pay for the salary employee
           this is just the salary of the employee            */
        public override double calculateYearlyPay()
        {
            yearlyPay = Salary;
            return yearlyPay;
        }

        /* toString Override for the SalaryEmpoyee object */
        public override string ToString()
        {
            String output;
            output = "Salary Employee: " + employeeNumber + " " + "Name: " + 
                firstName + " " + lastName + " Salary: $" + calculateMonthlyPay();
            return output;
        }
    }
}
