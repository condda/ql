using AST.Nodes.Interfaces;
using AST.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expression = AST.Nodes.Expression;
namespace AST.Evaluation
{
    public class ExpressionVisitor : BaseVisitor<bool>
    {
         IDictionary<string, IValue> identifierLookup;

        public ExpressionVisitor(IDictionary<string, IValue> identifierLookup)
        {
            this.identifierLookup = identifierLookup;
        }

        public override bool Visit(Expression.And node)
        {
            return node.Left.Accept(this) && node.Right.Accept(this);
        }
        public bool Visit(Expression.Or node)
        {
            return node.Left.Accept(this) || node.Right.Accept(this);
        }
        public bool Visit(Expression.Equal node)
        {
            return node.Left.Accept(this) == node.Right.Accept(this);
        }

        public bool Visit(Expression.NotEqual node)
        {
            return node.Left.Accept(this) != node.Right.Accept(this);
        }
        public bool Visit(Expression.Negate node)
        {
            return !node;
        }
        public bool Visit(Expression.Container node) { }
        public bool Visit(Expression.Priority priority) { }
    }
}
