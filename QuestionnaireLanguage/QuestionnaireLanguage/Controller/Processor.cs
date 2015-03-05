using QuestionnaireLanguage.GUI.FormObject;
using QuestionnaireLanguage.GUI.Interfaces.FormObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using AST.Nodes.FormObject;
using System.Windows;
using AST.Nodes;
using AST.Representation;
using QuestionnaireLanguage.Resources;
using ASTIFormObject = AST.Nodes.Interfaces;
using AST.Nodes.TypeName;
using QuestionnaireLanguage.GUI.Factories.FormObjects;
using AST.Nodes.Expression;
using QuestionnaireLanguage.GUI.CustomUIElements.CustomControls;
using AST;
using QuestionnaireLanguage.Visitors;
using QuestionnaireLanguage.GUI.Widgets;

namespace QuestionnaireLanguage.Controller
{
    public class Processor
    {
        private static ASTResult astTree;

        public static ASTResult AstTree
        {
            get { return astTree; }
            private set { astTree = value; }
        }

        public Processor() { }

        public Processor(ASTResult astTree)
        {
            AstTree = astTree;
        }

        public UIElement ProcessAST()
        {
            Widget panelWidget = new StackPanelWidget(true);
            UIElement uiPanel = panelWidget.CreateUIControl();
            
            foreach (ASTIFormObject.IFormObject node in ((astTree.Ast) as Form).getChildren())
            {
                FormObjectVisitor visitor = new FormObjectVisitor();
                IFormObject formElement = visitor.VisitFormObject(node);

                uiPanel = formElement.ProcessFormObject(uiPanel);

                /*
                 * Add a visitor to determine if the node to process is a FORM or is a CONDITIONAL
                 *      In order to allow this we need to move FORM to FormObject and implement Form : IFormObject
                 *      -> astTree.Ast.Accept(new FormObjectVisitor());
                 */
            }
            return uiPanel;
        }

        public UIElement ProcessNode(Conditional node)
        {
            UIElement uiControlElement = null;

            Widget panelWidget = new StackPanelWidget(true);

            foreach (ASTIFormObject.IFormObject bodyElement in node.Body)
            {
                FormObjectVisitor visitor = new FormObjectVisitor();
                IFormObject formElement = visitor.VisitFormObject(bodyElement);

                uiControlElement = formElement.ProcessFormObject(panelWidget.CreateUIControl());
            }

            return uiControlElement;
        }

        public Control FindControl(UIElementCollection controls, string nameControlToFind)
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

        /*TODO
         * - Update SymbolTable
         * - Evaluate inputs
         * - Change visibility
         */
    }
}
