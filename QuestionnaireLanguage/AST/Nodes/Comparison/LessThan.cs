using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Comparison
{
    public class LessThan : IComparison
    {
        private IArithmetic left;
        private IArithmetic right;
        private Representation.PositionInText position;

        public LessThan(IArithmetic left, IArithmetic right, Representation.PositionInText position)
        {
            this.left = left;
            this.right = right;
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
