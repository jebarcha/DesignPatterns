using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class ErrorDecorator : IArtefact
    {
        private IArtefact artefact;

        public ErrorDecorator(IArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string render()
        {
            var mainIcon = artefact.render();
            return mainIcon + " [Error]";
        }
    }
}
