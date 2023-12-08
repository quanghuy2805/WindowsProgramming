using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise7c
{
    internal class Program
    {


        public class Users
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Salary { get; set; }

        }


        static void Main(string[] args)
        {
            List<Users> userlist = new List<Users>
             {
                new Users {FName= "John", LName= "Doe", Salary = 1230},
                new Users {FName= "Lucy", LName= "Novak", Salary = 670},
                new Users {FName= "Ben", LName= "Walter", Salary = 2050},
                new Users {FName= "Robin", LName= "Brown", Salary = 2300},
                new Users {FName= "Amy", LName= "Doe", Salary = 1250},
                new Users {FName= "Joe", LName= "Draker", Salary = 1190},
                new Users {FName= "Janet", LName= "Doe", Salary =980},
                new Users {FName= "Alert", LName= "Novak", Salary = 1930},

            };
            IEnumerable<Users> result = (from Employee in userlist
                                             orderby Employee.LName ascending, Employee.Salary ascending
                                             select Employee);


            result.ToList().ForEach(Employee => Console.WriteLine($"{Employee.LName}, {Employee.Salary}"));
            IEnumerable<Users> result1 = (from Employee1 in userlist
                                              where Employee1.Salary > 1500
                                              select Employee1);


            result1.ToList().ForEach(Employee1 => Console.WriteLine($"Salary > 1500: {Employee1.FName}"));
            Console.ReadKey();
        }
    }
}