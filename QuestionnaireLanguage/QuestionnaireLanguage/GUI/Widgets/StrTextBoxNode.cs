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
using System.Windows.Input;
using Values = AST.Nodes.Values;

namespace QuestionnaireLanguage.GUI.Widgets
{
    public class StrTextBoxNode : TextBoxNode, ITextBoxWidget
    {
        public StrTextBoxNode()
        {

        }

        public StrTextBoxNode(string id, Values.String node)
        {
            Id = id;
        }

        public override UIElement CreateUIControl()
        {
            return new CustomTextBox(false) { Name = Id };
        }
    }
}
