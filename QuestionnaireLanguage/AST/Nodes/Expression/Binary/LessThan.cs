using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Expression.Binary
{
    public class LessThan : IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }
        private Representation.PositionInText position;

        public LessThan(IExpression left, IExpression right, Representation.PositionInText position)
        {
            this.Left = left;
            this.Right = right;
            this.position = position;
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
