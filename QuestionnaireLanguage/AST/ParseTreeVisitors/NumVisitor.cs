using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grammar;
using AST.Nodes.Interfaces;
using Values = AST.Nodes.Values;
using AST.Helpers;

namespace AST.ParseTreeVisitors
{
    public class NumVisitor : QLMainBaseVisitor<INum>
    {
        public override INum VisitNumInt(QLMainParser.NumIntContext context)
        {
           string representation = context.@int().INT().GetText(); 
           int value = int.Parse(representation);

           return new Values.Int(representation, value,
                                 Position.PositionFormParserRuleContext(context));

        }
        public override INum VisitNumMoney(QLMainParser.NumMoneyContext context)
        {
            string representation = context.money().MONEY().GetText();
            double value = double.Parse(representation);

            return new Values.Money(representation, value,
                                    Position.PositionFormParserRuleContext(context));

        }
        public override INum VisitNumDecimal(QLMainParser.NumDecimalContext context)
        {
            string representation = context.@decimal().DECIMAL().GetText();
            double value = double.Parse(representation);

            return new Values.Decimal(representation, value,
                                      Position.PositionFormParserRuleContext(context));
        }
    }
}
