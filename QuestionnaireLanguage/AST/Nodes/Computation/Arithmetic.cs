using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Computation
{
    public class Arithmetic : ASTNode, IComputation
    {
        private string parsedString;
        public IArithmetic ArithmeticValue {get; private set;}

        public Arithmetic(string parsedString, IArithmetic arithmeticValue, PositionInText positionInText)
            : base(positionInText)
        {
            this.parsedString = parsedString;
            this.ArithmeticValue = arithmeticValue;
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
