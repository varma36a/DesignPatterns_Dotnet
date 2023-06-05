using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class Bike : IVehicle
    {
        public virtual void Create()
        {
            Console.WriteLine("Bike");
        }
    }
}
