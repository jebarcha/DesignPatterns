using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class DirectionServiceWithTheProblem
    {
        private TravelMode travelMode;

        public Object getEta()
        {
            if (travelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating ETA (driving)");
                return 1;
            }
            else if (travelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating ETA (bicycling)");
                return 2;
            }
            else if (travelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating ETA (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating ETA (walking)");
                return 4;
            }
        }

        public Object getDirection()
        {
            if (travelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating Direction (driving)");
                return 1;
            }
            else if (travelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating Direction (bicycling)");
                return 2;
            }
            else if (travelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating Direction (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Direction (walking)");
                return 4;
            }
        }

        public TravelMode getTravelMode()
        {
            return travelMode;
        }

        public void setTravelMode(TravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

    }
}
