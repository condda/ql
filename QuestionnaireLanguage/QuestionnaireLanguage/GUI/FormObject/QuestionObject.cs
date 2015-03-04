using AST.Nodes.FormObject;
using AST.Nodes.Interfaces;
using QuestionnaireLanguage.GUI.Factories.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.Widgets;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using QuestionnaireLanguage.GUI.Interfaces.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using AST.Resources;

namespace QuestionnaireLanguage.GUI.FormObject
{
    public class QuestionObject : ObjectBase, IFormElement
    {
        private Question questionNode;

        #region Constructors
        public QuestionObject(Question node)
        {
            this.questionNode = node;
        }
        #endregion

        #region Private Methods
        private UIElement CreateQuestionLabel(string content)
        {
            return new Label() { Content = content };
        }
        #endregion

        #region IFormObject
        public UIElement ProcessFormObject(UIElement form)
        {
            StackPanel uiControlPanel = new StackPanel();
            uiControlPanel.Children.Add(CreateQuestionLabel((questionNode.Label as AST.Nodes.Labels.Label).Value));

            /*
             * Node.TypeName: Visit to know the instance.
             * 
             * Node.GetProperties: Iterate through them to know the properties and create label. 
             *                     ValidKeyValuePairs.
            */
            
            int value = 1;
            IWidget controlElement = WidgetFactory.GetControlElement(
                this.questionNode.Identifier, new AST.Nodes.Values.Int(value)
                //new AST.Nodes.Values.Bool("", true, new AST.Representation.PositionInText())
                //new AST.Nodes.Values.String()
                );


            uiControlPanel.Children.Add(controlElement.CreateUIControl());

            return AddChildren(uiControlPanel, form);
        }
        #endregion

        private string GetLabelContent()
        {
            string label = string.Empty;

            
            //foreach (IKeyValuePairNode item in questionNode.Label)
            //{
                //if (item.Key == "label")
                //{
                //    label = (item.Value as AST.Nodes.Values.String).Value.ToString();
                //}
            //}

            return label;
        }
    }
}
