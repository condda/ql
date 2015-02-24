using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Values
{
    public class String : IValue
    {
        private string representation;
        private string value;
        private PositionInText position;

        public String()
        {}

        public String(string representation, string value, PositionInText position)
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
