using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise7a
{
    internal class Program
    {
        public class User
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Adress { get; set; }
            public int DOB { get; set; }
        }
        static void Main(string[] args)
        {
            List<User> listuser = new List<User>
             {
                new User {ID=1, Name="Jhon", Adress="London", DOB= 2001-04-01 },
                new User {ID=2, Name="Lenny", Adress="New York", DOB=1977-12-11 },
                new User {ID=3, Name="Andrew", Adress="Boston", DOB=1987-02-22 },
                new User {ID=4, Name="Peter", Adress="Prague", DOB=1936-03-24 },
                new User {ID=5, Name="Anna", Adress="Bratislava", DOB=1973-11-18 },
                new User {ID=6, Name="Albert", Adress="Bratislava", DOB= 1940-12-11 },
                new User {ID=7, Name="Adam", Adress="Trnava", DOB=1983-12-01 },
                new User {ID=8, Name="Robert", Adress="Bratislava", DOB= 1935-05-15 },
                new User {ID=9, Name="Robert", Adress="Prague", DOB= 1988-03-14 },
            };
            IEnumerable<User> result = (from A in listuser
                                        where A.Adress == "Bratislava"
                                        select A);

            result.ToList().ForEach(A => Console.WriteLine(A.Name));
            Console.ReadKey();
        }
    }
}