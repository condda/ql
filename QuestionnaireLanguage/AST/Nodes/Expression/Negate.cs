using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression
{
    public class Negate : IExpressionNode
    {
        private PositionInText position;
        private IExpressionNode child;


        public Negate(IExpressionNode child, PositionInText position)
        {
            this.child = child;
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}


