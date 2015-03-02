using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AST.Nodes;
using AST.Nodes.Interfaces;
using AST.Nodes.FormObject;
using Arithmetic = AST.Nodes.Arithmetic;
using Expression = AST.Nodes.Expression;
using Comparison = AST.Nodes.Comparison;
using Values     = AST.Nodes.Values;
using KeyVal     = AST.Nodes.KeyValuePair;


namespace AST.Visitors
{
    public interface IVisitor
    {
        void Visit(Form node);
        void Visit(Question node);
        
        //Arithmetic
        void Visit(Arithmetic.Add node);
        void Visit(Arithmetic.Subtract node);
        void Visit(Arithmetic.Divide node);
        void Visit(Arithmetic.Multiply node);
        void Visit(Arithmetic.Container node);
        void Visit(Arithmetic.Id node);
        
        //Comparison
        void Visit(Comparison.GreaterThan node);
        void Visit(Comparison.GreaterThanOrEqual node);
        void Visit(Comparison.LessThan node);
        void Visit(Comparison.LessThanOrEqual node);

        //Expression
        void Visit(Expression.And node);
        void Visit(Expression.Or node);
        void Visit(Expression.Equal node);
        void Visit(Expression.NotEqual node);
        void Visit(Expression.Negate node);
        void Visit(Expression.Container<IValue> node);
        void Visit(Expression.Priority priority);

        //Values
        void Visit(Values.Bool node);
        void Visit(Values.Int node);
        void Visit(Values.String node);
        void Visit(Values.Unknown node);
        
        //KeyValuePair
        void Visit(KeyVal.KeyArithmeticPair node);
        void Visit(KeyVal.KeyExpressionPair node);
        void Visit(KeyVal.KeyValuePair node);

    }
    public interface IVisitor<T>
    {
        T Visit(Form node);
        T Visit(Question node);

        //Arithmetic
        T Visit(Arithmetic.Add node);
        T Visit(Arithmetic.Subtract node);
        T Visit(Arithmetic.Divide node);
        T Visit(Arithmetic.Multiply node);
        T Visit(Arithmetic.Container node);
        T Visit(Arithmetic.Id node);

        //Comparison
        T Visit(Comparison.GreaterThan node);
        T Visit(Comparison.GreaterThanOrEqual node);
        T Visit(Comparison.LessThan node);
        T Visit(Comparison.LessThanOrEqual node);

        //Expression
        T Visit(Expression.And node);
        T Visit(Expression.Or node);
        T Visit(Expression.Equal node);
        T Visit(Expression.NotEqual node);
        T Visit(Expression.Negate node);
        T Visit(Expression.Container<IValue> node);
        T Visit(Expression.Priority priority);

        //Values
        T Visit(Values.Bool node);
        T Visit(Values.Int node);
        T Visit(Values.String node);
        T Visit(Values.Unknown node);

        //KeyValuePair
        T Visit(KeyVal.KeyArithmeticPair node);
        T Visit(KeyVal.KeyExpressionPair node);
        T Visit(KeyVal.KeyValuePair node);


    }
}
