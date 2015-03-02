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


namespace AST.ParseTreeVisitors
{
    public class TypeVisitor : QLMainBaseVisitor<IType>
    {
        public override IType VisitBoolType(QLMainParser.BoolTypeContext context)
        {
            return new TypeName(context.BOOL().GetText(), Types.BOOL, 
                                Position.PositionFormParserRuleContext(context)); 
        }

        public override IType VisitStringType(QLMainParser.StringTypeContext context)
        {
            return new TypeName(context.STRING().GetText(), Types.STRING,
                                Position.PositionFormParserRuleContext(context));
        }

        public override IType VisitIntType(QLMainParser.IntTypeContext context)
        {
            return new TypeName(context.INT().GetText(), Types.INT,
                                Position.PositionFormParserRuleContext(context));
        }
    }
}
