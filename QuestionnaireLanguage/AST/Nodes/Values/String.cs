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
    public class String : IValue
    {
        private readonly string value;
        public String(string value)
        {
            this.value = value;
        }
        public override ValueTypes.Types GetType(Storage.ISymbolTable lookup)
        {
            return ValueTypes.Types.STRING;
        }

        // Visitor Methods
        public T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
