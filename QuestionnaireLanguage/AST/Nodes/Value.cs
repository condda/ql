using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes
{
    public class Value : IExpressionNode, IArithmeticNode
    {
        private PositionInText position;

        //TODO: Add LiteralValue storage


        public Value(PositionInText position)
        {
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
