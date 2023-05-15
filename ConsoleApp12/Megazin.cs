using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Megazin
    {
        public string name { get; set; }
        public string born_year { get; set; }
        public string description { get; set; }
        public string num { get; set; }
        public string email { get; set; }

        public Megazin() 
        {
            name = Console.ReadLine();
            description = Console.ReadLine();
            born_year = Console.ReadLine();
            description = Console.ReadLine();
            num = Console.ReadLine();
            email = Console.ReadLine();
        }
    }
}
