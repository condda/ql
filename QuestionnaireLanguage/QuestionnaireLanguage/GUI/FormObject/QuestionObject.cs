using AST.Nodes.FormObject;
using ASTIFormObject = AST.Nodes.Interfaces;
using QuestionnaireLanguage.GUI.Factories.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using QuestionnaireLanguage.GUI.Interfaces.FormObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using AST.Resources;
using QuestionnaireLanguage.Visitors;
using QuestionnaireLanguage.GUI.Widgets;

namespace QuestionnaireLanguage.GUI.FormObject
{
    public class QuestionObject : ObjectBase, IFormObject
    {
        private Question questionNode;

        #region Constructors
        public QuestionObject(Question node)
        {
            this.questionNode = node;
        }
        #endregion

        #region Private Methods
        #endregion

        #region IFormObject
        public UIElement ProcessFormObject(UIElement form)
        {
<<<<<<< HEAD
            //StackPanelWidget stackPanelWidget = new StackPanelWidget(true);
            //UIElement customStackPanel = stackPanelWidget.CreateUIControl();

            ValueVisitor visitor = new ValueVisitor(questionNode.Identifier);
            Widget widget = visitor.VisitValue(questionNode.Value);

            LabelVisitor labelVisitor = new LabelVisitor();
            Widget labelWidget = labelVisitor.VisitValue(questionNode.Label);
=======
            Widget widget = new ValueVisitor(questionNode.Identifier).VisitValue(questionNode.Value);
            Widget labelWidget = new LabelVisitor().VisitValue(questionNode.Label);
>>>>>>> origin/master

            AddChildren(labelWidget.CreateUIControl(), form);
            AddChildren(widget.CreateUIControl(), form);

            return form;
        }
        #endregion
    }
}
