using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Values
{
    public class Int : INum 
    {
        private string representation;
        private int value;
        private PositionInText position;

        public Int(string representation, int value, PositionInText position)
        {
            // TODO: Complete member initialization
            this.representation = representation;
            this.value = value;
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
