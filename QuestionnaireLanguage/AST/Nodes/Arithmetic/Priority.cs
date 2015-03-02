using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Arithmetic
{
    public class Priority : IArithmeticNode
    {
        private IArithmeticNode child;
        private Representation.PositionInText position;

        public Priority(IArithmeticNode child, PositionInText position)
        {
            this.child = child;
            this.position = position;
        }
    }
}
