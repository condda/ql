using AST.Nodes.Interfaces;
using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST.ParseTreeVisitors
{
    public class TypeNameVisitor : QLMainBaseVisitor<ITypeName>
    {
        public override ITypeName VisitPrimitiveTypeName(QLMainParser.PrimitiveTypeNameContext context)
        {
            //todo
            return base.VisitPrimitiveTypeName(context);
        }

        public override ITypeName VisitListTypeName(QLMainParser.ListTypeNameContext context)
        {   //todo
            return base.VisitListTypeName(context);
        }
    }
}
