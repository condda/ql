using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.TypeName
{
    public class ListTypeName : ITypeName
    {
        PrimitiveTypeName primitive;
        PositionInText position;
        public ListTypeName(PositionInText position)
        {
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
