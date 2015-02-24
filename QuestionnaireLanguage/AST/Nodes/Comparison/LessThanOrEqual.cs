using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Comparison
{
    public class LessThanOrEqual : IComparisonNode
    {
        private IArithmeticNode left;
        private IArithmeticNode right;
        private Representation.PositionInText position;

        public LessThanOrEqual(IArithmeticNode left, IArithmeticNode right, Representation.PositionInText position)
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
