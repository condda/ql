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
        private IList<IFormObject> body;
        private IExpression condition;
        private PositionInText positionInText;

        public Conditional(IExpression condition, 
                           IList<IFormObject> body, 
                           PositionInText positionInText)
        {
            this.condition = condition;
            this.body = body;
            this.positionInText = positionInText;
        }

        public PositionInText GetPositionInText()
        {
            return positionInText;
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
