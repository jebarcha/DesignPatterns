using System;

namespace Command
{
    public class Button
    {
        private String label;
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
        public String GetLabel() 
        {
            return label;
        }
        public void SetLabel(String label) 
        {
            this.label = label;
        } 
        

    }
}
