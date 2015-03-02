using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Arithmetic
{
    public class Subtract : ASTNode, IArithmeticNode
    {
        public IArithmeticNode left { get; private set; }
        public IArithmeticNode right { get; private set; }
        private string parsedString;
        
        public Subtract(IArithmeticNode left, IArithmeticNode right, string parsedString, PositionInText position)
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
