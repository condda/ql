using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Arithmetic
{
    public class Priority : IArithmeticNode
    {
        private IArithmeticNode arithmeticNode;
        private Representation.PositionInText position;

        public Priority(IArithmeticNode arithmeticNode, Representation.PositionInText position)
        {
            this.arithmeticNode = arithmeticNode;
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
