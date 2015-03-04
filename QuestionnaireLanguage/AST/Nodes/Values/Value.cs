using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueTypes = AST.Resources;

namespace AST.Nodes.Values
{
    public abstract class Value//<T>
    {
        //private readonly T value;
        //public Value(T value)
        //{
        //    this.value = value;
        //}

        public abstract Bool BoolAnd(Bool boolValue);
        public abstract Bool BoolOr(Bool boolValue);
        public abstract Bool BoolEqual(Bool boolValue);
        public abstract Bool BoolNotEqual(Bool boolValue);

        public abstract bool GetValue();

        //public abstract Bool Negate();

        //public Bool Equal(T value)
        //{
        //    return new Bool(GetValue() == value);
        //}

        //public Bool NotEqual(T value)
        //{
        //    return new Bool(this.value != value);
        //}

        //public T GetValue()
        //{
        //    return this.value;
        //}

    }
}
