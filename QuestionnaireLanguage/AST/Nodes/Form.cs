using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;


namespace AST.Nodes
{
    public class Form : IASTNode
    {
        private List<IFormObjectNode> body;
        private PositionInText position;

        public Form(List<IFormObjectNode> body, PositionInText position)
        {
            this.position = position;
            this.body = body;
        }

        public List<IFormObjectNode> getChildren() { return body; }
        public PositionInText GetPositionInText(){ return position; }
    }
}
