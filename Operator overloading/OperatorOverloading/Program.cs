using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person list = new Person();
            #region PersonArr
            list.Add(new Person { Age = 17 });
            list.Add(new Person { Age = 18 });
            list.Add(new Person { Age = 19 });
            list.Add(new Person { Age = 20 });
            //list.GetAll();
            #endregion
        }
    }
}