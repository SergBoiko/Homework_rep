using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_ClassLibrary
{
    public class ClassicCoffeeCake : Bakery
    {
        public ClassicCoffeeCake (string name)
        {
            this.Name = name;
        }
        
    }
}
