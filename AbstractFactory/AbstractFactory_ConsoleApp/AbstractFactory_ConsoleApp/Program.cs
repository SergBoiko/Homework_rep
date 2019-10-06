using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_ClassLibrary;

namespace AbstractFactory_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {              
            var starbucks = new KharkivStarbucks();
            
            Console.WriteLine(starbucks.MakeCake().Name);
            starbucks.MakeCoffee(3).ForEach((c) => Console.WriteLine(c.Name));
            starbucks.MakeLunch(4).ForEach((p) => Console.WriteLine(p.Name));

            Console.ReadKey();
        }
    }
}
