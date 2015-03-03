using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class Priority : ASTNode, IExpression
    {
        private IExpression child;
        string parsedString;
        public Priority(IExpression child, string parsedString, PositionInText position)
            : base(position)
        {
            this.child = child;
            this.parsedString = parsedString;
        }

        public override string GetParsedString()
        { return parsedString; }

        //Visitor methods
        public T Accept<T>(Visitors.IVisitor<T> visitor)
        { return visitor.Visit(this); }

        public void Accept(Visitors.IVisitor visitor)
        { visitor.Visit(this); }


    }
}
