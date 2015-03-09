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
    public class Id : IExpression, IValue
    {
        public string Identifier { get; private set; }
        public PositionInText Position {get; private set; }

        public Id(string identifier, PositionInText position)
        {
            this.Identifier = identifier;
            this.Position = position;
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
