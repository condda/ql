using AST.Nodes.Interfaces;
using AST.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Expression.Binary;
using AST.Nodes.Expression.Unary;
using AST.Nodes.Expression;
namespace AST.Evaluation
{
    public class ExpressionVisitor : BaseVisitor<bool>
    {
         IDictionary<string, IValue> identifierLookup;

        public ExpressionVisitor(IDictionary<string, IValue> identifierLookup)
        {
            this.identifierLookup = identifierLookup;
        }

        public override bool Visit(And node)
        {
            return node.Left.Accept(this) && node.Right.Accept(this);
        }
        public bool Visit(Or node)
        {
            return node.Left.Accept(this) || node.Right.Accept(this);
        }
        public bool Visit(Equal node)
        {
            return node.Left.Accept(this) == node.Right.Accept(this);
        }

        public bool Visit(NotEqual node)
        {
            return node.Left.Accept(this) != node.Right.Accept(this);
        }
        public bool Visit(Negate node)
        {
            return true;
        }
        public bool Visit(Container node) {
            return true;
        }
    }
}
