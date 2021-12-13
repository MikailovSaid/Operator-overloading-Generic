using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Person
    {
        public string Name { get; set; }
        public string Surame { get; set; }
        public int Age { get; set; }

        Person[] arr;

        public Person()
        {
            arr = new Person[0];
        }
        public void Add(Person obj)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = obj;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.Age);
            }
        }
    }
}
