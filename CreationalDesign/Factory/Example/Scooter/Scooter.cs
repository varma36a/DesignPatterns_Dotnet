using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class Scooter : IVehicle
    {
        public virtual void Create()
        {
            Console.WriteLine("Scooter");
        }
    }
}
