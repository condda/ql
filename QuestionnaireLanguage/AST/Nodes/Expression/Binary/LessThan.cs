﻿using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Representation;

namespace AST.Nodes.Expression.Binary
{
    public class LessThan : IExpression
    {
        private IExpression left;
        private IExpression right;
        private Representation.PositionInText position;

        public LessThan(IExpression left, IExpression right, Representation.PositionInText position)
        {
            this.left = left;
            this.right = right;
            this.position = position;
        }

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