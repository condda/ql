using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes;
using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Resources;
using ValueTypes = AST.Resources;

namespace AST.Nodes.Values
{
    public class Bool : ValueNode<bool>
    {
        public Bool(string representation, bool parsedValue, PositionInText position)
            :base(representation, parsedValue, position) { }

        public override ValueTypes.Types GetType(Storage.ISymbolTable lookup)
        {
            return ValueTypes.Types.STRING;
        }

        // Visitor Methods
        public override T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public override void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }




    }
}
