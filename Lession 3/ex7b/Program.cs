using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Exercise7b
{
    internal class Program
    {


        public class Cars
        {
            public string Name { get; set; }
            public int cost { get; set; }

        }


        static void Main(string[] args)
        {
            List<Cars> carlist = new List<Cars>
             {
                new Cars { Name="Audi", cost = 52642 },
                new Cars { Name="Mercedes", cost = 57127 },
                new Cars { Name="Skoda", cost = 9000 },
                new Cars { Name="Volvo", cost = 29000 },
                new Cars { Name="Bently", cost = 350000 },
                new Cars { Name="Citroen", cost = 21000 },
                new Cars { Name="Hummer", cost = 41400 },
                new Cars { Name="Volkswagen", cost = 21600 },
            };
            IEnumerable<Cars> result = (from A in carlist
                                        where A.cost > 30000 && A.cost < 100000
                                        select A);

            result.ToList().ForEach(A => Console.WriteLine(A.Name));
            Console.ReadKey();
        }
    }
}