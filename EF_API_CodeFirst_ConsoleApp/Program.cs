using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_API_CodeFirst_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OfficeContext())
            {
                Employee emp = new Employee()
                {
                    EmployeeName = "Chris",
                    DateOfBirth = DateTime.Parse("jan-15-1993"),
                    EmployeeID = 0
                };

                context.Employees.Add(emp);
                context.SaveChanges();
                Console.Write("Changes saved");
                Console.ReadLine();
            }
        }
    }

    public class Employee
    {
        public Employee()
        {

        }

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }

    public class OfficeContext : DbContext
    {
        public OfficeContext() : base()
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
