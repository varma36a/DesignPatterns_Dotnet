using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address Clone()
        {
            return this.MemberwiseClone() as Address;
        }
    }
}
