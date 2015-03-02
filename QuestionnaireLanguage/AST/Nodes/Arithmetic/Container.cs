using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Arithmetic
{
    public class Container<V> : ASTNode, IArithmeticNode
        where V : IValue
    {
        public IValue value { get; private set; }
        private string parsedString;

        public Container(string parsedString, V value, PositionInText position)
            : base(position)
        {
            this.value = value;
            this.parsedString = parsedString;
        }
        public override string GetParsedString()
        {
            return parsedString;
        }

        //Visitor Methods
        public override void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
