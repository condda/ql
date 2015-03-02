using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Nodes.Values;

namespace AST.Nodes.Expression
{
    public class Container<T> : IExpressionNode
        where T : IValue
    {
        private T value;
        private string representation;
        private PositionInText position;

        public Container(string representation, T value, PositionInText position)
        {
            this.value = value;
            this.representation = representation;
            this.position = position;
        }

    }
}
