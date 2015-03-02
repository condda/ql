using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;
using AST.Storage;
using ValueTypes = AST.Resources;

namespace AST.Nodes.Values
{
    public class String : ValueNode<string>
    {
        public String(string parsedString, string value, PositionInText position)
            : base(parsedString, value, position) {}
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
