using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class Artefact : IArtefact
    {
        private String name;
        public Artefact(String name)
        {
            this.name = name;
        }
        public String render()
        {
            return name;
        }
    }
}
