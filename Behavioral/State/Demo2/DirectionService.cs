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
        public Object GetEta()
        {
            return travelMode.GetEta();
        }
        public Object GetDirection()
        {
            return travelMode.GetDirection();
        }
        public ITravelMode GetTravelMode()
        {
            return travelMode;
        }
        public void SetTravelMode(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

    }
}
