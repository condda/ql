using AST.Helpers;
using AST.Nodes.Expression;
using AST.Nodes.Interfaces;
using AST.Representation;
using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.ParseTreeVisitors
{
    public class AssociativeVisitor : QLMainBaseVisitor<IExpression>
    {
        public override IExpression VisitPriorityAssociative(QLMainParser.PriorityAssociativeContext context)
        {
            return context.expression().Accept(new ExpressionVisitor());
        }

        public override IExpression VisitAND(QLMainParser.ANDContext context)
        {
            return new And(
                    context.associative(0).Accept(this),
                    context.associative(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpression VisitOR(QLMainParser.ORContext context)
        {
            return new Or(
                    context.associative(0).Accept(this),
                    context.associative(1).Accept(this),
                    Position.PositionFormParserRuleContext(context)
                );
        }

        public override IExpression VisitDIV(QLMainParser.DIVContext context)
        {
            var ArithmeticVisitor = new ArithmeticVisitor();
            IArithmetic left = context.associative(0).Accept(ArithmeticVisitor);
            IArithmetic right = context.associative(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            return new Divide(left, right, context.GetText(), position);
        }

        public override IExpression VisitMUL(QLMainParser.MULContext context)
        {
            var ArithmeticVisitor = new ArithmeticVisitor();
            IArithmetic left = context.associative(0).Accept(ArithmeticVisitor);
            IArithmetic right = context.associative(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            return new Multiply(left, right, context.GetText(), position);
        }
        public override IArithmetic VisitSUB(QLMainParser.SUBContext context)
        {
            var ArithmeticVisitor = new ArithmeticVisitor();
            IArithmetic left = context.associative(0).Accept(ArithmeticVisitor);
            IArithmetic right = context.associative(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            return new Subtract(left, right, context.GetText(), position);
        }

        public override IArithmetic VisitADD(QLMainParser.ADDContext context)
        {
            var ArithmeticVisitor = new ArithmeticVisitor();
            IArithmetic left = context.associative(0).Accept(ArithmeticVisitor);
            IArithmetic right = context.associative(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            return new Add(left, right, context.GetText(), position);
        }

        public override IExpression VisitAssociativeValue(QLMainParser.AssociativeValueContext context)
        {
            var visitor = new ValueVisitor();
            IValue value = context.value().Accept(visitor);

            return value;
        }

        public override IExpression VisitAssociativeId(QLMainParser.AssociativeIdContext context)
        {
            var associativeVisitor = new AssociativeVisitor();
            IExpression value = context.id().Accept(associativeVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            return new Add(left, right, context.GetText(), position);
        }
    }
}
