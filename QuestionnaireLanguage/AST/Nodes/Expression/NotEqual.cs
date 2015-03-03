using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class NotEqual : IExpression
    {
        public IArithmetic Left { get; private set; }
        public IArithmetic Right { get; private set; }
        private PositionInText position;

        public NotEqual(IArithmetic left, IArithmetic right, PositionInText position)
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
