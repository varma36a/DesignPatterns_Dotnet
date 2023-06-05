using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Example
{
    public class VehicleFactory
    {
        public static IVehicle CreateBike(BikeType type, BikeModel model)
        {
            switch (type)
            {
                case BikeType.Bike:
                    return ConstructBike(model);
                case BikeType.Scooter:
                    return ConstructScooter(model);
                default:
                    return new RegularBike();
            }
        }

        private static Scooter ConstructScooter(BikeModel model)
        {
            switch (model)
            {
                case BikeModel.RegularScooter:
                    return new RegularScooter();
                case BikeModel.Scooty:
                    return new Scooty();
                default:
                    return new RegularScooter();
            }
        }

        private static IVehicle ConstructBike(BikeModel model)
        {
            switch (model)
            {
                case BikeModel.RegularBike:
                    return new RegularBike();
                case BikeModel.SportBike:
                    return new SportsBike();
                default:
                    return new RegularBike();
            }
        }

    }
}
