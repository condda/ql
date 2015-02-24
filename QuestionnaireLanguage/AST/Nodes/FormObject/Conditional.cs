using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.FormObject
{
    public class Conditional : IFormObjectNode
    {
        private IList<IFormObjectNode> body;
        private IExpressionNode condition;
        private PositionInText positionInText;

        public Conditional(IExpressionNode condition, 
                           IList<IFormObjectNode> body, 
                           PositionInText positionInText)
        {
            this.condition = condition;
            this.body = body;
            this.positionInText = positionInText;
        }

        public Representation.PositionInText GetPositionInText()
        {
            throw new NotImplementedException();
        }
    }
}
