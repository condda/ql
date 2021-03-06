﻿using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Nodes.Expression.Binary
{
    public class LessThanOrEqual : ASTNode, IExpression, IBinary
    {

        private readonly IExpression left;
        private readonly IExpression right;
        private Representation.PositionInText position;

        public LessThanOrEqual(IExpression left, IExpression right, Representation.PositionInText position)
            : base(position)
        {
            this.left = left;
            this.right = right;

            this.position = position;
        }

        public IExpression Left()
        { return left; }

        public IExpression Right()
        { return right; }

        public void Accept(Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public T Accept<T>(Visitors.IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public override string GetParsedString()
        {
            throw new NotImplementedException();
        }

        public string MakeString()
        {
            return ">=";
        }

        public Types.Type GetCompatibleType(Types.IntType leftType, Types.IntType rightType)
        {
            return new Types.BoolType();
        }

        public Types.Type GetCompatibleType(Types.Type leftType, Types.Type rightType)
        {
            return new Types.UndefinedType();
        }
    }
}
