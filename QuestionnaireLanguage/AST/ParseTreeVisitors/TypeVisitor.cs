using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grammar;
using AST.Nodes.Interfaces;
using AST.Nodes.Values;
using AST.Representation;
using AST.Helpers;
using Values = AST.Nodes.Values;
namespace AST.ParseTreeVisitors
{
    public class ValueVisitor : QLMainBaseVisitor<IValue>
    {
        public override IValue VisitBoolValue(QLMainParser.BoolValueContext context)
        {
            int tokenInt = context.@bool().val.Type;
            
            if(tokenInt == QLMainParser.TRUE)
                return new Values.Bool("True", true, Position.PositionFormParserRuleContext(context));
            else if (tokenInt == QLMainParser.FALSE)
                return new Values.Bool("True", true, Position.PositionFormParserRuleContext(context));
            else
                throw new InvalidOperationException("Boolean was neither True nor False");
        }
        public override IValue VisitStringValue(QLMainParser.StringValueContext context)
        {
            string stringValue = context.@string().STRING().GetText();

            return new Values.String(stringValue, 
                                     stringValue.Substring(1, stringValue.Length-2), 
                                     Position.PositionFormParserRuleContext(context)
                                     ); 
        }
        public override IValue VisitDateValue(QLMainParser.DateValueContext context)
        {
            context.date().y.GetText();

            int year  = int.Parse(context.date().y.GetText());
            var month = int.Parse(context.date().m.GetText());
            var day   = int.Parse(context.date().d.GetText());

            try
            {
                DateTime dateValue = new DateTime(year, month, day);
                return new Values.Date(context.date().GetText(),
                                 new DateTime(year, month, day),
                                 Position.PositionFormParserRuleContext(context));
            }
            catch (ArgumentOutOfRangeException e)
            {
                //TODO, add parse error to exceptions if not able to parse into DateTime
                return new Values.Date(context.date().GetText(),
                                       new DateTime(0),
                                       Position.PositionFormParserRuleContext(context)
                                       );
            }

        }
        public override IValue VisitNumValue(QLMainParser.NumValueContext context)
        {
            return context.num().Accept(new NumVisitor());
        }

        public override IValue VisitListValue(QLMainParser.ListValueContext context)
        {
            return new Values.List( context.list().GetText(),
                                    context.list()._listItems.Select(child => child.Accept(this)),
                                    Position.PositionFormParserRuleContext(context));
        }

    }
}
