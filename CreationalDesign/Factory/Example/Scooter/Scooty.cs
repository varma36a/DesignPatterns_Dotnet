using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class Scooty:Scooter
    {
        public override void Create()
        {
            Console.WriteLine("Scooty");
        }
    }
}
