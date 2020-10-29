using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class DirectionService
    {
        private ITravelMode travelMode;
        public DirectionService(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }
        public Object getEta()
        {
            return travelMode.getEta();
        }
        public Object getDirection()
        {
            return travelMode.getDirection();
        }
        public ITravelMode getTravelMode()
        {
            return travelMode;
        }
        public void setTravelMode(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

    }
}
