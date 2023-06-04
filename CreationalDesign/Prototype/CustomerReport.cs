using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class CustomerReport
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address PermanentAddress { get; set; }
        public Address CurrentAddress { get; set; }

        public abstract object Clone();
        public abstract CustomerReport DeepClone();
    }
}
