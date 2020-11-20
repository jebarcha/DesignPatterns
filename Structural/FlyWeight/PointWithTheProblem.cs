using System;

namespace FlyWeight
{
    public class PointWithTheProblem
    {
        private int x;  // 4 bytes
        private int y;  // 4 bytes
        private PointType type;  // 4 bytes
        private byte[] icon; // 20 bytes

        public PointWithTheProblem(int x, int y, PointType type, byte[] icon)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{type} at ({x},{y})");
        }
    }
}
