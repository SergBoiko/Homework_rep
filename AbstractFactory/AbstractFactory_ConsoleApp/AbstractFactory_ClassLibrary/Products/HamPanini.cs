using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_ClassLibrary.Products
{
    public class HamPanini : Lunch
    {
        public HamPanini(string name)
        {
            Name = name;
        }
    }
}
