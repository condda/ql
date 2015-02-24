using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class Priority : IExpressionNode
    {
        private IExpressionNode child;
        private PositionInText position;
        public Priority(IExpressionNode child, PositionInText position)
        {
            this.child = child;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
