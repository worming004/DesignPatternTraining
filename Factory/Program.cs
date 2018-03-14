using Factory.Situation;
using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Traveler> travelers = new List<Traveler>()
            {
                new Traveler{FullName="MS"},
                new Traveler{FullName="JCA"}
            };

            var paris = new Location { CityName = "Paris" };
            var rome = new Location { CityName = "Rome" };

            var travel = new Travel(paris, rome, travelers);
            Console.WriteLine(travel.Vehicle.ToString());
            Console.ReadLine();
        }
    }
}
