using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Nodes.Values;

namespace AST.Nodes.Arithmetic
{
    public class Id : IArithmeticNode, IValue
    {
        public string identifier { get; private set; }
        public PositionInText position {get; private set; }

        public Id(string identifier, PositionInText position)
        {
            this.identifier = identifier;
            this.position = position;
        }
    }
}
