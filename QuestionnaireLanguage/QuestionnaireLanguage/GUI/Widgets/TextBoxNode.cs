using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuestionnaireLanguage.GUI.Widgets
{
    public abstract class TextBoxNode : WidgetBase, ITextBoxWidget
    {
        public abstract UIElement CreateUIControl();
    }
}
