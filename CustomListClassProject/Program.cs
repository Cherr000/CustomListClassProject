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
            ListClass<int> list = new ListClass<int>() { 1, 2, 3, 4, 5 };
            int three = 3;
            int five = 5;
            list.Remove(three);
            list.Remove(five);
            Console.ReadLine();
        }
    }
}
