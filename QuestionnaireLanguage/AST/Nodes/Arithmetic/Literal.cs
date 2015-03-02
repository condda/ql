using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;

namespace AST.Nodes.Arithmetic
{
    public class Literal : IArithmeticNode, IValue
    {
        private int value;
        private string representation;
        private PositionInText position;
    
        public Literal(string representation, int value, PositionInText position)
        {
            this.value = value;
            this.representation = representation;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
