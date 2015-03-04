using QuestionnaireLanguage.GUI.FormObject;
using QuestionnaireLanguage.GUI.Interfaces.Form;
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
using AST.Nodes.Interfaces;
using AST.Nodes.TypeName;
using QuestionnaireLanguage.GUI.Factories.FormObjects;
using AST.Nodes.Expression;
using QuestionnaireLanguage.GUI.CustomControls;
using AST;
using QuestionnaireLanguage.Visitors;

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
            UIElement uiControlElement = null;

            StackPanel panel = new StackPanel();

            foreach (IFormObject node in ((astTree.Ast) as Form).getChildren())
            {
                FormObjectVisitor visitor = new FormObjectVisitor();
                IFormElement formElement = visitor.VisitFormObject(node);

                uiControlElement = formElement.ProcessFormObject(panel);

                /*
                 * Change the if and instead use visitors (ask if they are going to be implemented in the AST layer
                 *
                 * Think where to create the evaluator (we have here the AST object with the SymbolTable)
                 * 
                 * Refactor in order to allow a call from the Conditional Form Object.
                 *
                 */
            }

            //Change the object to the specific object from the AST structure
            //IList<IKeyValuePairNode> valPairList = new List<IKeyValuePairNode>();
            //PositionInText position = new PositionInText();

            //ITypeName typeName = new PrimitiveTypeName(position);

            //Question node = new Question("Q1",typeName,valPairList,position);

            //Conditional nodeC = new Conditional(
            //    new And(new Id("IdTxt", position), new Id("Q2", position), position),
            //    new List<IFormObjectNode>(),
            //    position);

           // StackPanel mainPanel = new StackPanel();
            //mainPanel.Children.Add(new CustomTextBox(false) { Name = "IdTxt"});

            //IFormElement formElement = FormObjectFactory.GetFormObject(node);
            //uiControlElement = formElement.ProcessFormObject(mainPanel);

            //IFormElement formElement = FormObjectFactory.GetFormElement(node);
            //UIElement uiControlElement = formElement.CreateUIControl();


            return uiControlElement;
        }

        /*TODO
         * - Update SymbolTable
         * - Evaluate inputs
         * - Change visibility
         */
    }
}
