using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class GoldCustomerReport : CustomerReport
    {
        public override object Clone()
        {
            return this.MemberwiseClone() as CustomerReport;
        }

        public override CustomerReport DeepClone()
        {
            CustomerReport customer =  this.MemberwiseClone() as CustomerReport;
            customer.PermanentAddress = this.PermanentAddress.Clone();
            customer.CurrentAddress = this.CurrentAddress.Clone();

            //customer.PermanentAddress = new Address
            //{
            //    Address1 = this.PermanentAddress.Address1,
            //    Address2 = this.PermanentAddress.Address2,
            //    State = this.PermanentAddress.State,
            //    City = this.PermanentAddress.City,i
            //    Zip = this.PermanentAddress.Zip,
            //};

            //customer.CurrentAddress = new Address
            //{
            //    Address1 = this.CurrentAddress.Address1,
            //    Address2 = this.CurrentAddress.Address2,
            //    State = this.CurrentAddress.State,
            //    City = this.CurrentAddress.City,
            //    Zip = this.CurrentAddress.Zip,
            //};

            return customer;
        }
    }
}
