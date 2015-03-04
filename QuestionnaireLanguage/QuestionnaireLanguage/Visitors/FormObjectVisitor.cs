using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.FormObject;
using QuestionnaireLanguage.GUI.FormObject;
using QuestionnaireLanguage.GUI.Factories.FormObjects;
using AST.Nodes.Interfaces;
using QuestionnaireLanguage.Visitors.Interfaces;
using QuestionnaireLanguage.GUI.Interfaces.Form;

namespace QuestionnaireLanguage.Visitors
{
    public class FormObjectVisitor : IFormObjectVisitor
    {
        public IFormElement VisitFormObject(IFormObject formObject)
        {
            return Visit((dynamic) formObject);
        }
        public ConditionalObject Visit(Conditional conditional)
        {
            return FormObjectFactory.GetFormObject(conditional);
        }
        public QuestionObject Visit(Question question)
        {
            return FormObjectFactory.GetFormObject(question);
        }
    }
}
