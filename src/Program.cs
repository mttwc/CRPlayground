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
            var pet = new Pet("Dinky", "German Shepherd");
            Console.WriteLine("Hello " + pet.Name + "! You're a cute " + pet.Species + "!");

            Console.Read();
        }
    }
}
