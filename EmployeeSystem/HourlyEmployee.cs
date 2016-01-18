using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
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

        /* TODO Data Validation */
        public double DollarsPerHour {
            get { return dollarsperhour;
            }  set {
                dollarsperhour = value;
            }
        }

        /* TODO data validation */
        public double Hours {
            get {
                return hours;
            }
            set {
                hours = value;
            }
        }

        public HourlyEmployee(string fn, string ln, int empN, double dph, double hr) : base(fn, ln, empN)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = empN;
            DollarsPerHour = dph;
            Hours = hr;
            try {
                InsertIntoDB();
            }
            catch (Exception e)
            {
                //Console.WriteLine("ERROR WRITING TO DATABASE");
                //Console.WriteLine(e.Message);
            }
            
        }

        public override double calculateMonthlyPay()
        {
            return DollarsPerHour * hours;
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

        [SqlProcedure()]
        public override void InsertIntoDB()
        { 
            var connectionString =
                "Data Source=(LocalDB)\\MSSQLLocalDB;"+
                "AttachDbFilename=F:\\Visual Studio DB\\EmployeeDatabase.mdf;" +
                "Integrated Security=True";

            using (var conn = new SqlConnection(connectionString)) {
                using (SqlCommand command = new SqlCommand("AddHourly", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    conn.Open();
                    //Console.WriteLine("employeeNumber: " + employeeNumber);
                    command.Parameters.Add(new SqlParameter("@employeeId", employeeNumber));
                    command.Parameters.Add(new SqlParameter("@firstName", firstName));
                    command.Parameters.Add(new SqlParameter("@lastName", lastName));
                    command.Parameters.Add(new SqlParameter("@dollarsPerHour", dollarsperhour));
                    command.Parameters.Add(new SqlParameter("@hours", hours));

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}

