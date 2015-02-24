using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Arithmetic
{
    public class Divide : IArithmeticNode
    {
        private IArithmeticNode left;
        private IArithmeticNode right;
        private Representation.PositionInText position;

        public Divide(IArithmeticNode left, IArithmeticNode right, Representation.PositionInText position)
        {
            this.left = left;
            this.right = right;
            this.position = position;
        }
        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
