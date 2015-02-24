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
    public class Bool //: ITypeNode
    {
        public Bool value;
        public PositionInText position;

        public Bool(bool value, PositionInText position)
        {
        }

        public PositionInText GetPositionInText()
        {
           return position;
        }
    }
}
