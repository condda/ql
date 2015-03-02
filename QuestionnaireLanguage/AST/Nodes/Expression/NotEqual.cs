using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class NotEqual : IExpressionNode
    {
        private IArithmeticNode left;
        private IArithmeticNode right;
        private PositionInText position;

        public NotEqual(IArithmeticNode left, IArithmeticNode right, PositionInText position)
        {
            this.left = left;
            this.right = right;
            this.position = position;
        }

    }
}
