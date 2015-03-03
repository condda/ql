using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.KeyValuePair
{
    public class KeyArithmeticPair : IKeyValuePairNode
    {
        private string key;
        private IArithmetic value;
        private PositionInText position;

        public KeyArithmeticPair(string key, IArithmetic value, PositionInText position)
        {
            this.key = key;
            this.value = value;
            this.position = position;
        }

        public Representation.PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
