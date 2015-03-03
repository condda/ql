using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Nodes.Values;

namespace AST.Nodes.Expression
{
    public class Container : IExpression
    {
        private IValue value;
        private string representation;
        private PositionInText position;

        public Container(string representation, IValue value, PositionInText position)
        {
            this.value = value;
            this.representation = representation;
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
