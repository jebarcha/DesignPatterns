using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class MainDecorator : IArtefact
    {
        private IArtefact artefact;
        public MainDecorator(IArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string render()
        {
            return artefact.render() + " [Main]";
        }
    }
}
