using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.TypeName
{
    public class PrimitiveTypeName : ITypeName
    {
        private PositionInText position;

        public PrimitiveTypeName(PositionInText position)
        {
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            throw new NotImplementedException();
        }
    }
}
