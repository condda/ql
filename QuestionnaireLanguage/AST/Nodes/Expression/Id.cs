﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Nodes.Values;

namespace AST.Nodes.Expression
{
    public class Id : ASTNode, IExpression
    {
        public string identifier { get; private set; }
        
        public Id(string identifier, PositionInText position)
            : base(position)
        {
            this.identifier = identifier;
        }

        public override void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public override string GetParsedString()
        {
            throw new NotImplementedException();
        }
    }
}
