using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grammar;
using AST.Nodes;
using AST.Nodes.Interfaces;
using AST.Nodes.Expression;
using AST.Representation;
using AST.Helpers;
using AST.Nodes.Values;

namespace AST.ParseTreeVisitors
{
    public class ExpressionVisitor : QLMainBaseVisitor<IExpressionNode>
    {
        public override IExpressionNode VisitPriorityExpression(QLMainParser.PriorityExpressionContext context)
        {
            return new Priority(context.expression().Accept(this),
                                context.GetText(),
                                Position.PositionFormParserRuleContext(context));
        }

        public override IExpressionNode VisitBoolExpression(QLMainParser.BoolExpressionContext context)
        {
            var boolContext = context.@bool();

            return new Container<IValue>(boolContext.GetText(), 
                                       boolContext.Accept(new ValueVisitor()), 
                                       Position.PositionFormParserRuleContext(context));
        }

        public override IExpressionNode VisitIdExpression(QLMainParser.IdExpressionContext context)
        {
            var IdContext = context.id();
            return new Container<IValue>(IdContext.GetText(), 
                                         IdContext.Accept(new ValueVisitor()),
                                         Position.PositionFormParserRuleContext(context));
        }

        public override IExpressionNode VisitNegate(QLMainParser.NegateContext context)
        {
            return new Negate(context.expression().Accept(this),
                              Position.PositionFormParserRuleContext(context));
        }

        public override IExpressionNode VisitAnd(QLMainParser.AndContext context)
        {
            return new And(
                    context.expression(0).Accept(this),
                    context.expression(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpressionNode VisitOr(QLMainParser.OrContext context)
        {
            return new Or(
                    context.expression(0).Accept(this),
                    context.expression(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpressionNode VisitEquality(QLMainParser.EqualityContext context)
        {

            IArithmeticNode left     = context.arithmetic(0).Accept(new ArithmeticVisitor());
            IArithmeticNode right    = context.arithmetic(1).Accept(new ArithmeticVisitor());
            PositionInText  position = Position.PositionFormParserRuleContext(context);

            switch(context.op.Type)
            {
                case QLMainParser.EQ  : return new Equal(left, right, position);
                case QLMainParser.NEQ : return new NotEqual(left, right, position);
                default : throw new InvalidOperationException("Token does not match any of the valid token options");
            }
        }

        public override IExpressionNode VisitComparisonExpression(QLMainParser.ComparisonExpressionContext context)
        {
            return context.comparison().Accept(new ComparisonVisitor());
        }
    }
}
