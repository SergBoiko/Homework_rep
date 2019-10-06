using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_ClassLibrary;

namespace AbstractFactory_ClassLibrary
{
    public abstract class Starbucks
    {
        public abstract Bakery MakeCake();
        public abstract List<Coffee> MakeCoffee(int number);
        public abstract List<Lunch> MakeLunch(int number);
    }
}
