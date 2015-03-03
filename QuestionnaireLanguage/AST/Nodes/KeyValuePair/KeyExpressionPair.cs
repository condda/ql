using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.KeyValuePair
{
    public class KeyExpressionPair : IKeyValuePairNode
    {
        private string key;
        private IExpression value;
        private PositionInText position;

        public KeyExpressionPair(string key, IExpression value, PositionInText position)
        {
            this.key = key;
            this.value = value;
            this.position = position;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
