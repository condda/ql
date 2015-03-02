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
        public override IKeyValuePairNode VisitKvpExpression(QLMainParser.KvpExpressionContext context)
        {
            string key = context.key().GetText();
            IExpressionNode value = context.expression().Accept(new ExpressionVisitor());

            return new KeyExpressionPair(key, value,
                                    Position.PositionFormParserRuleContext(context));

        }

        public override IKeyValuePairNode VisitKvpArithmetic(QLMainParser.KvpArithmeticContext context)
        {
            string key = context.key().GetText();
            IArithmeticNode value = context.arithmetic().Accept(new ArithmeticVisitor());

            return new KeyArithmeticPair(key, value,
                                    Position.PositionFormParserRuleContext(context));
        }

        public override IKeyValuePairNode VisitKvpLiteral(QLMainParser.KvpLiteralContext context)
        {
            string key = context.key().GetText();
            IValue value = context.value().Accept(new ValueVisitor());

            return new KeyValuePair(key, value, 
                                    Position.PositionFormParserRuleContext(context));
        }

    }
}
