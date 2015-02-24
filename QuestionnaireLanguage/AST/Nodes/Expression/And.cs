using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class And : IExpressionNode
    {
        private IExpressionNode left;
        private IExpressionNode right;
        private PositionInText position;

        public And(IExpressionNode left, IExpressionNode right, PositionInText position)
        {
            this.left = left;
            this.right = right;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
