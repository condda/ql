using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes;
using AST.Nodes.Interfaces;
using AST.Representation;

namespace AST.Nodes.Values
{
    public class Bool : IValue
    {
        private string representation;
        private bool parsedValue;
        private PositionInText position;

        public Bool(string representation, bool parsedValue, PositionInText position)
        {
            this.representation = representation;
            this.parsedValue = parsedValue;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
           return position;
        }
    }
}
