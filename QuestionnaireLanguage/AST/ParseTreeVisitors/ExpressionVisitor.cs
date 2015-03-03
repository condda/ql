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
    public class ExpressionVisitor : QLMainBaseVisitor<IExpression>
    {
        public override IExpression VisitPriorityExpression(QLMainParser.PriorityExpressionContext context)
        {
            return new Priority(context.expression().Accept(this),
                                context.GetText(),
                                Position.PositionFormParserRuleContext(context));
        }

        public override IExpression VisitBoolExpression(QLMainParser.BoolExpressionContext context)
        {
            var boolContext = context.@bool();

            return new Container(boolContext.GetText(), 
                                       boolContext.Accept(new ValueVisitor()), 
                                       Position.PositionFormParserRuleContext(context));
        }

        public override IExpression VisitIdExpression(QLMainParser.IdExpressionContext context)
        {
            var IdContext = context.id();
            return new Container(IdContext.GetText(), 
                                         IdContext.Accept(new ValueVisitor()),
                                         Position.PositionFormParserRuleContext(context));
        }

        public override IExpression VisitNegate(QLMainParser.NegateContext context)
        {
            return new Negate(context.expression().Accept(this),
                              Position.PositionFormParserRuleContext(context));
        }

        public override IExpression VisitAnd(QLMainParser.AndContext context)
        {
            return new And(
                    context.expression(0).Accept(this),
                    context.expression(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpression VisitOr(QLMainParser.OrContext context)
        {
            return new Or(
                    context.expression(0).Accept(this),
                    context.expression(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpression VisitEquality(QLMainParser.EqualityContext context)
        {

            IArithmetic left     = context.arithmetic(0).Accept(new ArithmeticVisitor());
            IArithmetic right    = context.arithmetic(1).Accept(new ArithmeticVisitor());
            PositionInText  position = Position.PositionFormParserRuleContext(context);

            switch(context.op.Type)
            {
                case QLMainParser.EQ  : return new Equal(left, right, position);
                case QLMainParser.NEQ : return new NotEqual(left, right, position);
                default : throw new InvalidOperationException("Token does not match any of the valid token options");
            }
        }

        public override IExpression VisitComparisonExpression(QLMainParser.ComparisonExpressionContext context)
        {
            return context.comparison().Accept(new ComparisonVisitor());
        }
    }
}
