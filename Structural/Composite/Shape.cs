using System;

namespace Composite
{
    public class Shape: IComponent
    {
        public void Move()
        {
            Console.WriteLine("move Share");
        }

        public void Render() 
        {
            Console.WriteLine("Render Shape");
        }
    }
}
