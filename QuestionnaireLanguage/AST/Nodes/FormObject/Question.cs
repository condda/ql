using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Labels;
using Values = AST.Nodes.Values;

namespace AST.Nodes.FormObject
{
    public class Question : IFormObject
    {
        public ILabel Label {get; private set;}
        public IComputation Computation {get; private set;}
        public string Identifier {get; private set;}
        public Values.Value Value { get; private set; }
        private PositionInText positionInText;

        public Question(string identifier,
                        Values.Value value,
                        ILabel label,
                        IComputation computation,
                        PositionInText positionInText)
        {
            this.Identifier = identifier;
            this.Value = value;
            this.Label = label;
            this.Computation = computation;
            this.positionInText = positionInText;
        }

        public PositionInText GetPositionInText()
        { return positionInText; }

        public void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
