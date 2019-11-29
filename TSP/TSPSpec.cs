using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSPSolver.TSP
{
    public class TSPSpec
    {
        public TSPSpec(string name, IReadOnlyList<int> optTour, IReadOnlyList<Location> cities)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name must not be null or whitespace.", nameof(name));
            }

            Name = name;
            OptTour = optTour;
            Cities = cities;
        }

        public string Name { get; }

        public IReadOnlyList<int> OptTour { get; }

        public IReadOnlyList<Location> Cities { get; }
    }

    public class Location
    {
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }
}