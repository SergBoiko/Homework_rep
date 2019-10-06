using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionCars_ClassLibrary;

namespace CollectionsCarsHomeWork_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Car collection using IEnumerable");
            Cars<Car> cars = new Cars<Car>();

            cars.cars = new Car[3];
            cars.cars[0] = new Car("BMW", 25000, 230);
            cars.cars[1] = new Car("Porsche", 40000, 260);
            cars.cars[2] = new Car("Audi", 30000, 230);

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Name}, {car.Price}, {car.maxSpeed}");
            }           
            Console.ReadLine();
        }
    }
}
