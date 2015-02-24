using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grammar;
using AST.Nodes.Interfaces;
using AST.Nodes.Comparison;
using AST.Helpers;
using AST.Representation;

namespace AST.ParseTreeVisitors
{
    public class ComparisonVisitor : QLMainBaseVisitor<IComparisonNode>
    {
        public override IComparisonNode VisitPriorityComparison(QLMainParser.PriorityComparisonContext context)
        {
            return new Priority(context.comparison().Accept(this), 
                                Position.PositionFormParserRuleContext(context));
        }

        public override IComparisonNode VisitRelationalComparison(QLMainParser.RelationalComparisonContext context)
        {
            var ArithmeticVisitor   = new ArithmeticVisitor();
            IArithmeticNode left    = context.arithmetic(1).Accept(ArithmeticVisitor);
            IArithmeticNode right   = context.arithmetic(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            switch (context.op.Type)
            {
                case QLMainParser.LT : return new LessThan(left, right, position);
                case QLMainParser.LET: return new LessThanOrEqual(left, right, position);
                case QLMainParser.GT : return new GreaterThan(left, right, position);
                case QLMainParser.GET: return new GreaterThanOrEqual(left, right, position);
                default: throw new InvalidOperationException("Token does not match any of the valid token options");
            }
        }
    }
}
