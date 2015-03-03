using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Arithmetic
{
    public class Subtract : ASTNode, IArithmetic
    {
        public IArithmetic left { get; private set; }
        public IArithmetic right { get; private set; }
        private string parsedString;
        
        public Subtract(IArithmetic left, IArithmetic right, string parsedString, PositionInText position)
            : base(position)
        {
            this.left = left;
            this.right = right;
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
