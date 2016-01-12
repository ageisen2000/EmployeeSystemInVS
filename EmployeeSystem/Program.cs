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
            Employee e;
            List<Employee> company = new List<Employee>();
            Random r = new Random();

            double between;
            double high = 999999;
            double low = 100000;

            for (int i = 0; i < 10; i++)
            {
                    between = (r.NextDouble() * (high - low)) + low;
                    e = new HourlyEmployee("FN" + i, "LN" + i, (int)between, ((6 + i) * r.NextDouble()), ((10 + i) * r.NextDouble()));
                    company.Add(e);
            }

            for (int i = 0; i < 10; i++)
            {
                between = (r.NextDouble() * (high - low)) + low;
                e = new SalaryEmployee("FN" + i, "LN" + i, (int)between, ((40000 + i) * r.NextDouble()));
                company.Add(e);
            }
            
            foreach ( Employee z in company ){
                Console.WriteLine(z);
            }
            Console.Read();
        } 
    }

}
