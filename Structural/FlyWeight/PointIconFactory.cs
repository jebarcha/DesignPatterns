using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            // key -> value
            // PointType -> PointIcon

            if (!icons.ContainsKey(type)) 
            {
                var icon = new PointIcon(type, null);
                // phisical icon image, hospital.jpg, etc.
                icons.Add(type, icon);
            }

            return icons.GetValueOrDefault(type);
        }
    }
}
