using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST
{
    public interface IASTResult
    {
        void setValue(string key, ObjectValue value);
        ObjectValue getValue(Identifier key);
        bool isTypeCorrect();

        bool hasDuplicateIdentifiers();
        bool isCorrect();
    }
}
