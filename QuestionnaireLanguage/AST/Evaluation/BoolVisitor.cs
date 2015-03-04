using AST.Nodes.Expression.Binary;
using AST.Nodes.Expression.Unary;
using AST.Nodes.Values;
using AST.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Evaluation
{
    public class BoolVisitor : BaseVisitor<Value<Bool>>
    {
        public override Bool Visit(And node)
        {
            Value<Bool> left = node.Left.Accept(this);
            Value<Bool> right = node.Right.Accept(this);

            return left.BoolAnd((dynamic)right);
        }
        public override Bool Visit(Or node)
        {
            Value<Bool> left = node.Left.Accept(this);
            Value<Bool> right = node.Right.Accept(this);

            return left.BoolOr((dynamic)right);

        }
        public override Bool Visit(Equal node)
        {
            Value<Bool> left = node.Left.Accept(this);
            Value<Bool> right = node.Right.Accept(this);

            return left.BoolEqual((dynamic)right);
        }

        public override Bool Visit(NotEqual node)
        {
            Value<Bool> left = node.Left.Accept(this);
            Value<Bool> right = node.Right.Accept(this);

            return left.BoolNotEqual((dynamic)right);
        }
        public override Bool Visit(Negate node)
        {
            Value<Bool> value = node.Accept(this);
            return value.Negate();
        }
    }
}
