using AbstractFactory_ClassLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_ClassLibrary
{
    public class KharkivStarbucks : Starbucks
    {
        public override Bakery MakeCake()
        {            
            return new ClassicCoffeeCake("an amazing Classic Coffee Cake");
        }
        public override List<Coffee> MakeCoffee(int number)
        {
            List<Coffee> coffee = new List<Coffee>();
            for (int i = 0; i < number; i++)
            {
                coffee.Add(new DolceLatte(String.Format("a tasty fragrant Dolce Latte {0}", i + 1)));
            }
            return coffee;
        }
        public override List<Lunch> MakeLunch(int number)     
        {
            List<Lunch> panini = new List<Lunch>();
            for (int i = 0; i < number; i++)
            {
                panini.Add(new HamPanini(String.Format("a lovely Ham Panini {0}", i + 1)));
            }
            return panini;
        }

    }
}
