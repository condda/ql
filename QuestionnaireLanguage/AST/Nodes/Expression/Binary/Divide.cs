using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression.Binary
{
    public class Divide : ASTNode, IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }
        private string parsedString;

        public Divide(IExpression left, IExpression right, string parsedString, PositionInText position)
            : base(position)
        {
            this.Left = left;
            this.Right = right;
            this.parsedString = parsedString;
        }

        public override string GetParsedString()
        {
            return parsedString;
        }

        public void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public T Accept<T>(Visitors.IVisitor<T> visitor) 
        {
           return visitor.Visit(this);
        }
    }
}
