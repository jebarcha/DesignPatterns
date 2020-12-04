using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // all the logic in this single place
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            articlesListBox = new ListBox(this);
            titleTextBox = new TextBox(this);
            saveButton = new Button(this);
        }

        public void SimulateUserInteraction() 
        {
            articlesListBox.SetSelection("Article 1");
            Console.WriteLine("TextBox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
            Console.WriteLine("");

            titleTextBox.SetContent("");
            Console.WriteLine("TextBox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
            Console.WriteLine("");

            titleTextBox.SetContent("Article 2");
            Console.WriteLine("TextBox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
        }
        public override void Changed(UIControl control)
        {
            if (control == articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == titleTextBox) 
            {
                TitleChanged();
            }
        }
        private void TitleChanged() 
        {
            var content = titleTextBox.GetContent();
            saveButton.SetEnabled(!String.IsNullOrEmpty(content));
        }

        private void ArticleSelected() 
        {
            titleTextBox.SetContent(articlesListBox.GetSelection());
            saveButton.SetEnabled(true);
        }
    }
}
