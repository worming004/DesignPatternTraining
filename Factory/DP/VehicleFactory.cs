using Factory.Situation;
using Factory.Situation.Vehicles;
using System.Linq;

namespace Factory.DP
{
    public class VehicleFactory
    {

        public VehicleFactory()
        {
        }

        public static IVehicle getCorrectVehicleByTravel(Travel travel)
        {
            if (travel.Travelers.Count() <= 5) return new Car();
            if (travel.Travelers.Count() <= 10) return new Limousine();
            if (travel.Travelers.Count() <= 20) return new Boat();
            if (travel.Travelers.Count() <= 50) return new Limousine();
            throw new System.Exception("there is no acceptable vehicule"); // should be typed
        }
    }
}
