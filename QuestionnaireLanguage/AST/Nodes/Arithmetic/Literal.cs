using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;

namespace AST.Nodes.Arithmetic
{
    public class Literal : IArithmetic, IValue
    {
        private int value;
        private string representation;
        private PositionInText position;
    
        public Literal(string representation, int value, PositionInText position)
        {
            this.value = value;
            this.representation = representation;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
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
