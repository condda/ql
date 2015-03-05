using AST.Nodes.FormObject;
using QuestionnaireLanguage.Controller;
using QuestionnaireLanguage.GUI.CustomUIElements.CustomControls;
using QuestionnaireLanguage.GUI.CustomUIElements.CustomPanel;
using QuestionnaireLanguage.GUI.FormObject;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using QuestionnaireLanguage.GUI.Interfaces.FormObject;
using QuestionnaireLanguage.GUI.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.FormObject
{
    public class ConditionalObject : ObjectBase, IFormObject
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
            StackPanelWidget stackPanelWidget = new StackPanelWidget(false);
            UIElement customStackPanel = stackPanelWidget.CreateUIControl();

            
            //Evaluate the expression
            //customStackPanel.Visibility = Visibility.Hidden;

            /*
             * Add support to the stackpanel visibility (maybe add a new element to the symboltable)
             *      Create a method that searches and change visibility of stackpanel when needed.
             *      
             * Verify the conditional expression to set visibility
             * 
             * Get Id of elements from the expression (if exist).
             * Find elements in the form and assign stack
             */
            
            //CreateEvents(form);

            Processor processor = new Processor();
            Control control = processor.FindControl(((CustomStackPanel)form).Children, "q1"); //Obtain ICustomControl and add idStack. Visitor maybe

            AddChildren(processor.ProcessNode(conditionalNode), customStackPanel);

            return AddChildren(customStackPanel, form);
        }

        #endregion

        #region Private Methods

        //private void CreateEvents(UIElement form)
        //{
        //    try
        //    {
        //        Control controlFound = FindElement(((StackPanel)form).Children, "IdTxt"); //Change IdTxt to the ID of the element in the expression (if exist).
        //        (controlFound as ICustomControl).AddConditionalEvent();
        //    }
        //    catch (NullReferenceException e)
        //    {
        //        Console.WriteLine("Control Id not found: " + e.InnerException);
        //    }
        //    catch (InvalidCastException e)
        //    {
        //        Console.WriteLine("Form is not found StackPanel: " + e.InnerException);
        //    }
            
        //}
        
        #endregion
    }
}
