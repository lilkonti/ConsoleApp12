using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Site
    {
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string ip { get; set; }
        public Site() 
        {
            name = Console.ReadLine();
            description = Console.ReadLine();
            url = Console.ReadLine();
            ip = Console.ReadLine();
        }
    }
}
