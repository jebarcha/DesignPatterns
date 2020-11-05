using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Group: IComponent
    {
        // the group class can have zero o more shapes
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent shape)
        {
            components.Add(shape);
        }

        public void move()
        {
            foreach (var component in components)
            {
                component.move();
            }
        }

        public void render()
        { 
            foreach(var component in components) 
            {
                component.render();
            }

            // We do not have to check the type and cast

            //foreach(var @object in objects) 
            //{
            //    //shape.render();
            //    //if (shape.GetType() == typeof(Shape))
            //    if (@object is Shape)
            //    {
            //        ((Shape)@object).render();
            //    }
            //    else 
            //    {
            //        ((Group)@object).render();
            //    }
            //}
        }
    }

}
