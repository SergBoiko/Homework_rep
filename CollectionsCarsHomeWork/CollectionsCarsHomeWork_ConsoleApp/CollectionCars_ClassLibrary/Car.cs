using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionCars_ClassLibrary
{
    public class Car
    {
        public Car(string name, int price, int speed)
        {
            this.Name = name;
            this.Price = price;
            this.maxSpeed = speed;
        }

        public string Name { get; }
        public int Price { get; set; }
        public int maxSpeed { get; set; }
    }

    
}
