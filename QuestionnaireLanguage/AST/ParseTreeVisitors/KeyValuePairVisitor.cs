using AST.Helpers;
using AST.Nodes.Interfaces;
using AST.Nodes.KeyValuePair;
using AST.Representation;
using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST.ParseTreeVisitors
{
    public class KeyValuePairVisitor : QLMainBaseVisitor<IKeyValuePairNode>
    {
        public override IKeyValuePairNode VisitKeyValuePair(QLMainParser.KeyValuePairContext context)
        {
            string key = context.key().GetText();
            IExpressionNode value = context.expression().Accept(new ExpressionVisitor());

            return new KeyValuePair(key, value,
                                     Position.PositionFormParserRuleContext(context));
        }
    }
}
