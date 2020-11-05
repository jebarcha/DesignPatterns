using System;

namespace Composite
{
    public class Shape: IComponent
    {
        public void move()
        {
            Console.WriteLine("move Share");
        }

        public void render() 
        {
            Console.WriteLine("Render Shape");
        }
    }
}
