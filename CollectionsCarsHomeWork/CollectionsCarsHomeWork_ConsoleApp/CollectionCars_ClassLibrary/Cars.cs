using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCars_ClassLibrary
{
    public class Cars<T> : IEnumerable<T> 
    {
        public T[] cars;
        public Cars()
        {            
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T car in cars)
            {
                yield return car;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}