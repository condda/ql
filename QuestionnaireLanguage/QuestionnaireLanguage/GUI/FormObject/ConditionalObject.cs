using AST.Nodes.FormObject;
using QuestionnaireLanguage.Controller;
using QuestionnaireLanguage.GUI.CustomControls;
using QuestionnaireLanguage.GUI.FormObject;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using QuestionnaireLanguage.GUI.Interfaces.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.FormObject
{
    public class ConditionalObject : ObjectBase, IFormElement
    {
        private Conditional conditionalNode;

        #region Constructors
        public ConditionalObject(Conditional node)
        {
            this.conditionalNode = node;
        }

        #endregion

        #region IFormElement

        public UIElement ProcessFormObject(UIElement form)
        {
            StackPanel uiControlPanel = new StackPanel();
            
            //Evaluate the expression
            uiControlPanel.Visibility = Visibility.Hidden;

            Processor proc = new Processor();

            /*
             * Make a new call to the processor in order to obtain the elements inside the conditional
             * Add support to the stackpanel visibility (maybe add a new element to the symboltable)
             *      a way to relate the elements: Key:ConditionalExpression Value:StackPanelId
             *      Create a method that searches and change visibility of stackpanel when needed.
             */

            CreateEvents(form);

            return AddChildren(uiControlPanel, form);
        }

        #endregion

        #region Private Methods

        private void CreateEvents(UIElement form)
        {
            try
            {
                Control controlFound = FindElement(((StackPanel)form).Children, "IdTxt"); //Change IdTxt to node.Id
                (controlFound as ICustomControl).AddConditionalEvent();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Control Id not found: " + e.InnerException);
            }
            
        }
        
        private Control FindElement(UIElementCollection controls, string nameControlToFind) 
        {
            Control controlFound = null;
            
            foreach (Control control in controls.OfType<Control>())
            {
                if (control.Name.Equals(nameControlToFind))
                {
                    controlFound = control;
                    break;
                }
            }

            return controlFound;
        }
        
        #endregion
    }
}
