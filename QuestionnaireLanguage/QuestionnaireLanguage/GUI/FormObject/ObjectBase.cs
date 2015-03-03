using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.FormObject
{
    public class ObjectBase
    {
        public ObjectBase()
        { }

        public UIElement AddChildren(UIElement element, UIElement form)
        {
            try
            {
                ((StackPanel)form).Children.Add(element);
            }
            catch (NullReferenceException e)
            {

                Console.WriteLine(e.InnerException);
            }

            return form;
        }
    }
}
