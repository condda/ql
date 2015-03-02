using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class Or : IExpressionNode
    {
        private IExpressionNode left;
        private IExpressionNode right;
        private PositionInText position;

        public Or(IExpressionNode left, IExpressionNode right, PositionInText position)
        {
            this.left = left;
            this.right = right;
            this.position = position;
        }
    }
}
