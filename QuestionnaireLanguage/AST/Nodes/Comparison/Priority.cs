using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Comparison
{
    public class Priority : IComparisonNode
    {
        PositionInText position;
        IComparisonNode child;

        public Priority(IComparisonNode child, PositionInText position)
        {
            this.position = position;
            this.child = child;
        }
        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
