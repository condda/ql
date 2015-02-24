using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;


namespace AST.Nodes
{
    public class Id : IExpressionNode, IArithmeticNode
    {
        private string identifier;
        private PositionInText position;

        public Id(string identifier, PositionInText position)
        {
            this.identifier = identifier;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
