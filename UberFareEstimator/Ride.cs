using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFareEstimator
{
    public class Ride
    {
        /*
        public int time;
        public int distance;

        public double[] 

        
        // public int distance;

        public Ride(int time, int distance)
        {
            this.time = time;
            this.distance = distance;
        }
        */

        
        
        /*
        public int time
        {

            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
        */

        /*
        public int distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }
        */

        // public double[] costPerMinute;
        // public double[] costPerMile;

        

        public double[] FareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
        {
            // (Cost per minute) * (ride time) + (Cost per mile) * (ride distance)
            // Problem specification:
            // Return the fare estimates for all car types
            // How much will the ride cost for each car type?

            double[] fareEstimate = new double[cost_per_mile.Length];

            for (int i = 0; i < cost_per_mile.Length; i++)
            {
                // mileCost = cost_per_mile[i];
                // minuteCost = cost_per_minute[i];
                fareEstimate[i] = (double)(cost_per_minute[i] * ride_time) + (double)(cost_per_mile[i] * ride_distance);
            }

            // Return result array
            return fareEstimate;
        }


    }
}
