using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldCustomerReport goldCustomer = new GoldCustomerReport();

            goldCustomer.Id = 1;
            goldCustomer.FirstName = "Mohan";
            goldCustomer.LastName = "Kumar";
            goldCustomer.PermanentAddress = new Address
            {
                Address1 = "Noida Sector 15",
                Address2 = "Near Metro",
                State = "UP",
                City = "Noida",
                Zip = "201301"
            };
            goldCustomer.CurrentAddress = new Address
            {
                Address1 = "Lagpat Nager",
                Address2 = "Near Delhi Metro",
                State = "Delhi",
                City = "Delhi",
                Zip = "110091"
            };

            //TO DO: display report

            ////shallow copy
            //CustomerReport clone = (CustomerReport)goldCustomer.Clone();
            //Console.WriteLine($"Address1: {clone.CurrentAddress.Address1}");
            //Console.WriteLine($"Address1: {goldCustomer.CurrentAddress.Address1}");

            //clone.CurrentAddress.Address1 = "Delhi";
            //Console.WriteLine($"Address1: {clone.CurrentAddress.Address1}");
            //Console.WriteLine($"Address1: {goldCustomer.CurrentAddress.Address1}");

            //deep copy
            CustomerReport clone = (CustomerReport)goldCustomer.DeepClone();
            Console.WriteLine($"Address1: {clone.CurrentAddress.Address1}");
            Console.WriteLine($"Address1: {goldCustomer.CurrentAddress.Address1}");

            clone.CurrentAddress.Address1 = "Delhi";
            Console.WriteLine($"Address1: {clone.CurrentAddress.Address1}");
            Console.WriteLine($"Address1: {goldCustomer.CurrentAddress.Address1}");
        }
    }
}
