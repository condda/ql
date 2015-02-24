using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Values
{
    public class Money : INum
    {
        private string representation;
        private double value;
        private PositionInText position;

        public Money(string representation, double value, PositionInText position)
        {
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
