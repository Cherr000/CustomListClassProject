using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ListClass<string> list = new ListClass<string>();
            list.Add("Fuck");
            list.Add("You");
            Console.ReadLine();
        }
    }
}
