using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    public class PointIcon
    {
        private readonly PointType type;  // 4 bytes
        private readonly byte[] icon; // 20 bytes
        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }
        public PointType GetType()
        {
            return type;
        }
        
    }
}
