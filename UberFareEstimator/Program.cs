using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            Ride trip = new Ride();
            double[] minute_cost = { 0.2, 0.35, 0.4, 0.45 };
            double[] mile_cost = { 1.1, 1.8, 2.3, 3.5 };
            double[] results = trip.FareEstimator(30, 7, minute_cost, mile_cost);

            foreach(var result in results)
            {
                Console.WriteLine(result.ToString());
            }
            

            Console.ReadLine();
    }
    }
}
