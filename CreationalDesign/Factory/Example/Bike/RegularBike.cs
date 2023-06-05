using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class RegularBike : Bike
    {
        public override void Create()
        {
            Console.WriteLine("RegularBike");
        }
    }
}
