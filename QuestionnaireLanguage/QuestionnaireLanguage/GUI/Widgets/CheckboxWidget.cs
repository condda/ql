using AST.Nodes.Values;
using QuestionnaireLanguage.GUI.CustomControls;
using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.Widgets
{
    class CheckboxNode : WidgetBase, ICheckBoxWidget
    {
        public CheckboxNode(string id, Bool node)
        {
            Id = id;
        }

        public UIElement CreateUIControl()
        {
            return new CheckBox() { Name = Id };
        }
    }
}
