using System;
using System.Collections.Generic;
using System.Text;
using Factory.DP;
using Factory.Situation.Vehicles;

namespace Factory.Situation
{
    public class Travel
    {
        public IEnumerable<Traveler> Travelers { get; set; }
        public Location SourceLocation { get; set; }
        public Location Destination { get; set; }
        public IVehicle Vehicle { get; protected set; }

        public Travel(Location source, Location destination, IEnumerable<Traveler> travelers)
        {
            this.Travelers = travelers;
            this.SourceLocation = source;
            this.Destination = destination;
            this.Vehicle = VehicleFactory.getCorrectVehicleByTravel(this);
        }
    }
}
