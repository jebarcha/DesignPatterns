using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Demo2
{
    public class Editor
    {
        public void openProject(String path)
        {
            IArtefact[] artefacts = {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
        };

            // We can apply multiple decorators
            artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            artefacts[2] = new ErrorDecorator(artefacts[2]);

            // In the future, we can create a SourceControlDecorator that adds
            // a special marker to the icon if artefacts are not committed to the repository.

            foreach (var artefact in artefacts)
                Console.WriteLine(artefact.render());
        }
    }
}
