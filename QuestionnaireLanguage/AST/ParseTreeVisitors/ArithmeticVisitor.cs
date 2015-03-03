﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grammar;
using AST.Nodes.Interfaces;
using AST.Nodes.Arithmetic;
using AST.Representation;
using AST.Helpers;

namespace AST.ParseTreeVisitors
{
    public class ArithmeticVisitor : QLMainBaseVisitor<IArithmetic>
    {
        public override IArithmetic VisitPriorityArithmetic(QLMainParser.PriorityArithmeticContext context)
        {
            return new Priority(
                        context.arithmetic().Accept(this), 
                        Position.PositionFormParserRuleContext(context));
        }

        public override IArithmetic VisitDivMul(QLMainParser.DivMulContext context)
        {
            var ArithmeticVisitor   = new ArithmeticVisitor();
            IArithmetic left    = context.arithmetic(0).Accept(ArithmeticVisitor);
            IArithmetic right   = context.arithmetic(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            switch (context.op.Type)
            {
                case QLMainParser.DIV: return new Divide(left, right, context.GetText(), position);
                case QLMainParser.MUL: return new Multiply(left, right, context.GetText(), position);
                default: throw new InvalidOperationException("Token does not match any of the valid token options");
            }
        }
        public override IArithmetic VisitSubAdd(QLMainParser.SubAddContext context)
        {
            var ArithmeticVisitor = new ArithmeticVisitor();
            IArithmetic left = context.arithmetic(0).Accept(ArithmeticVisitor);
            IArithmetic right = context.arithmetic(1).Accept(ArithmeticVisitor);
            PositionInText position = Position.PositionFormParserRuleContext(context);

            switch (context.op.Type)
            {
                case QLMainParser.SUB: return new Subtract(left, right, context.GetText(), position);
                case QLMainParser.ADD: return new Add(left, right, context.GetText(), position);
                default: throw new InvalidOperationException("Token does not match any of the valid token options");
            }
        }

        public override IArithmetic VisitIntArithmetic(QLMainParser.IntArithmeticContext context)
        {
            string show = context.@int().GetText();
            int value = int.Parse(show);

            return new Literal(show, value, Position.PositionFormParserRuleContext(context));
        }
        public override IArithmetic VisitIdArithmetic(QLMainParser.IdArithmeticContext context)
        {
            return new Id(context.id().GetText(), Position.PositionFormParserRuleContext(context));
        }
    }
}
