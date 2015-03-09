using AST.Nodes.Interfaces;
using AST.Helpers;
using AST.Nodes.Values;
using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AST.Nodes.TypeName;
using AST.Resources;
using Values = AST.Nodes.Values;


namespace AST.ParseTreeVisitors
{
    public class TypeVisitor : QLMainBaseVisitor<IValue>
    {
        public override IValue VisitBoolType(QLMainParser.BoolTypeContext context)
        {
            //return new TypeName(context.BOOL().GetText(), Types.BOOL,
            //                    Position.PositionFormParserRuleContext(context));
            return new Values.Bool(false, Position.PositionFormParserRuleContext(context));
        }

        public override IValue VisitStringType(QLMainParser.StringTypeContext context)
        {
            //return new TypeName(context.STRING().GetText(), Types.STRING,
            //                    Position.PositionFormParserRuleContext(context));
            return new Values.String(string.Empty, Position.PositionFormParserRuleContext(context));
        }

        public override IValue VisitIntType(QLMainParser.IntTypeContext context)
        {
            //return new TypeName(context.INT().GetText(), Types.INT,
            //                    Position.PositionFormParserRuleContext(context));
            return new Values.Int(int.MinValue, Position.PositionFormParserRuleContext(context));
        }
    }
}
