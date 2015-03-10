using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.FormObject
{
    public class Conditional : IFormObject
    {
        public IList<IFormObject> Body { get; private set; }
        public IExpression Condition { get; private set; }
        private PositionInText positionInText;

        public Conditional(IExpression condition, 
                           IList<IFormObject> body, 
                           PositionInText positionInText)
        {
            this.Condition = condition;
            this.Body = body;
            this.positionInText = positionInText;
        }

        public void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public PositionInText GetPosition()
        {
            return positionInText;
        }
    }
}
