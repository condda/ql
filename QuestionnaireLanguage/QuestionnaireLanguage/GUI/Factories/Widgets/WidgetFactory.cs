using AST.Nodes.Values;
using QuestionnaireLanguage.GUI.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Values = AST.Nodes.Values;
namespace QuestionnaireLanguage.GUI.Factories.Widgets
{
    internal static class WidgetFactory
    {
        internal static TextBoxNode GetControlElement(string id, Values.String node)
        {
            return new StrTextBoxNode(id, node);
        }

        internal static CheckboxNode GetControlElement(string id, Bool node)
        {
            return new CheckboxNode(id, node);
        }

        internal static TextBoxNode GetControlElement(string id, Int node)
        {
            return new IntTextBoxWidget(id, node);
        }

        //internal static DatePickerWidget GetControlElement(string id, Date node)
        //{
        //    return new DatePickerWidget(id, node);
        //}
    }
}
