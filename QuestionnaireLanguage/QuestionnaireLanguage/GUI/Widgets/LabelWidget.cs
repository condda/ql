using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Labels = AST.Nodes.Labels;

namespace QuestionnaireLanguage.GUI.Widgets
{
    public class LabelWidget : WidgetBase, IWidget
    {
        public LabelWidget(Labels.Label node)
        {

        }
        public UIElement CreateUIControl()
        {
            throw new NotImplementedException();
        }
    }
}
