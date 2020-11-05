using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Demo2
{
    public class Team: Resource
    {
        private List<Resource> resources = new List<Resource>();

        public void add(Resource resource)
        {
            resources.Add(resource);
        }

        public void deploy()
        {
            foreach (var resource in resources)
                resource.deploy();
        }


        //private List<Object> resources = new List<Object>();

        //public void add(Object resource)
        //{
        //    resources.Add(resource);
        //}

        //public void deploy()
        //{

        //    foreach (var resource in resources)
        //    {
        //        if (resource is Truck)
        //            ((Truck)resource).deploy();
        //        else if (resource is HumanResource)
        //            ((HumanResource)resource).deploy();
        //        else
        //            ((Team)resource).deploy();
        //    }
        //}
    }
}
