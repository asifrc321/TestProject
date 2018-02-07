using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dummy app, doesn't do anything.");
            Parent f = new FirstChild();
            Console.WriteLine(f.Work());
        }
    }
}
