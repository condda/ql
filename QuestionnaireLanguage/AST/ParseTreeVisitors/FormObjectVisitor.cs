using AST.Nodes.FormObject;
using AST.Nodes.Interfaces;
using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AST.Representation;
using AST.Helpers;

namespace AST.ParseTreeVisitors
{
    public class FormObjectVisitor : QLMainBaseVisitor<IFormObjectNode>
    {
        public override IFormObjectNode VisitQuestion(QLMainParser.QuestionContext context)
        {

            string identifier = context.id().GetText();
            IType typeName = context.type().Accept(new TypeVisitor());

            List<IKeyValuePairNode> KeyValuePairs = context.keyValuePairs()
                                                    ._kvp
                                                    .Select(child => child.Accept(new KeyValuePairVisitor()))
                                                    .ToList();

            return new Question(identifier, typeName, KeyValuePairs,
                                Position.PositionFormParserRuleContext(context));
        }

        public override IFormObjectNode VisitConditional(QLMainParser.ConditionalContext context)
        {
            IExpressionNode condition = context.expression().Accept(new ExpressionVisitor());

            List<IFormObjectNode> body = context.formSection()
                                         .formObject()
                                         .Select(child => child.Accept(new FormObjectVisitor()))
                                         .ToList();

            return new Conditional(condition, body,
                                   Position.PositionFormParserRuleContext(context));

        }
    }
}
