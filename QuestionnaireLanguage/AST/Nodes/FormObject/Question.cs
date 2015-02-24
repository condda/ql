using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.FormObject
{
    public class Question : IFormObjectNode
    {
        private IList<IKeyValuePairNode> properties;
        private string identifier;
        private ITypeName typeName;
        private PositionInText positionInText;

        public Question(string identifier, 
                        ITypeName typeName, 
                        IList<IKeyValuePairNode> properties,
                        PositionInText positionInText)
        {
            this.identifier = identifier;
            this.typeName = typeName;
            this.properties = properties;
            this.positionInText = positionInText;
        }

        public PositionInText GetPositionInText()
        { return positionInText; }

        public IList<IKeyValuePairNode> getProperties()
        { return properties; }
    }
}
