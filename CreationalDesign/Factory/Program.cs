using Factory.Example;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = LoggerFactory.CreateLogger(LoggerType.Console);
            //Client client = new Client(logger);
            //client.Add();

            IVehicle vehicle1 = VehicleFactory.CreateBike(BikeType.Bike,BikeModel.RegularBike);
            vehicle1.Create();
            IVehicle vehicle2 = VehicleFactory.CreateBike(BikeType.Bike, BikeModel.SportBike);
            vehicle2.Create();
            IVehicle vehicle3 = VehicleFactory.CreateBike(BikeType.Scooter, BikeModel.RegularScooter);
            vehicle3.Create();
            IVehicle vehicle4 = VehicleFactory.CreateBike(BikeType.Scooter, BikeModel.Scooty);
            vehicle4.Create();
        }
    }
}
