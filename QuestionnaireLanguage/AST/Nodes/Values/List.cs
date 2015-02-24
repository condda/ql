using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Values
{
    public class List :IValue
    {
        private string representation;
        private IEnumerable<IValue> children;
        private PositionInText position;

        public List(string representation, IEnumerable<IValue> children, PositionInText position)
        {
            // TODO: Complete member initialization
            this.representation = representation;
            this.children = children;
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
