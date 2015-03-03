using QuestionnaireLanguage.GUI.CustomControls;
using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Values = AST.Nodes.Values;

namespace QuestionnaireLanguage.GUI.Widgets
{
    class IntTextBoxWidget : TextBoxNode
    {
        public IntTextBoxWidget(){}

        public override UIElement CreateUIControl()
        {
            return new CustomTextBox(true) { Name = Id };
        }

        public IntTextBoxWidget(string id, Values.Int node)
        {
            Id = id;
        }
    }
}
