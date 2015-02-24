using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Arithmetic
{
    public class Subtract : IArithmeticNode
    {
        private IArithmeticNode left;
        private IArithmeticNode right;
        private Representation.PositionInText position;
        
        public Subtract(IArithmeticNode left, IArithmeticNode right, PositionInText position)
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
