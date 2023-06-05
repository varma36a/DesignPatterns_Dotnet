using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class RegularScooter:Scooter
    {
        public override void Create()
        {
            Console.WriteLine("RegularScooter");
        }
    }
}
