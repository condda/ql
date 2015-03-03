using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Visitors
{
    public abstract class BaseVisitor<T> : IVisitor<T>
    {
        public virtual T Visit(Nodes.Form node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.FormObject.Question node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Add node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Subtract node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Divide node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Multiply node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Container node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Arithmetic.Id node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Comparison.GreaterThan node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Comparison.GreaterThanOrEqual node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Comparison.LessThan node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Comparison.LessThanOrEqual node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.And node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.Or node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.Equal node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.NotEqual node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.Negate node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Expression.Container node)
        {
            throw new NotImplementedException();
        }
        public T Visit(Nodes.Expression.Priority priority)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Values.Bool node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Values.Int node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Values.String node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Values.Unknown node)
        {
            throw new NotImplementedException();
        }



        public virtual T Visit(Nodes.Labels.Label node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Computation.Id node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Computation.Value node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Computation.Arithmetic node)
        {
            throw new NotImplementedException();
        }

        public virtual T Visit(Nodes.Computation.Expression node)
        {
            throw new NotImplementedException();
        }


        public object Visit(Nodes.Arithmetic.Literal literal)
        {
            throw new NotImplementedException();
        }


        public object Visit(Nodes.Arithmetic.Priority priority)
        {
            throw new NotImplementedException();
        }


        public object Visit(Nodes.Comparison.Priority priority)
        {
            throw new NotImplementedException();
        }


        T IVisitor<T>.Visit(Nodes.Arithmetic.Literal literal)
        {
            throw new NotImplementedException();
        }

        T IVisitor<T>.Visit(Nodes.Arithmetic.Priority priority)
        {
            throw new NotImplementedException();
        }

        T IVisitor<T>.Visit(Nodes.Comparison.Priority priority)
        {
            throw new NotImplementedException();
        }

        public T Visit(Nodes.FormObject.Conditional conditional)
        {
            throw new NotImplementedException();
        }

        public T Visit(Nodes.TypeName.TypeName typeName)
        {
            throw new NotImplementedException();
        }
    }
}
