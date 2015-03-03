﻿using AST.Nodes.Interfaces;
using AST.Representation;
using AST.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Visitors;

namespace AST.Nodes
{
    public abstract class ASTNode : IASTNode
    {
        public PositionInText Position{ get; private set; }
        protected ASTNode(PositionInText position)
        {
            Position = position;
        }
        public abstract string GetParsedString();

        public virtual void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public virtual T Accept<T>(IVisitor<T> visitor)
        {
            throw new NotImplementedException();
        }
    }
}