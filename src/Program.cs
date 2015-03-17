using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("matthew", 23);
            Console.WriteLine("Hello " + person.Name + "!");

            Console.Read();
        }
    }
}
