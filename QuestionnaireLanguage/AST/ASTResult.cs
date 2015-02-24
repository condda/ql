using AST.Nodes.Interfaces;
using AST.Notification;
using AST.Representation;
using AST.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST
{
    public class ASTResult : IASTResult
    {
        private IASTNode ast;
        private SymbolTable table;
        private List<INotification> notifications;

        public ASTResult(IASTNode tree)
        {
            this.ast = tree;
            table = new SymbolTable();
            
            //todo: traverse AST and typecheck
            //todo: init notifications and stuff
            //todo: probably something else

        }

        public void setValue(Identifier key, ObjectValue value)
        {
            table.SetObjectValue(key, value);   
        }

        public ObjectValue getValue(Identifier key)
        {
            return table.GetObjectValue(key);
        }

        public bool isTypeCorrect()
        {
            throw new NotImplementedException();
        }

        public bool hasDuplicateIdentifiers()
        {
            throw new NotImplementedException();
        }

        public bool isCorrect()
        {
            throw new NotImplementedException();
        }

        public void setValue(string key, ObjectValue value)
        {
            throw new NotImplementedException();
        }
    }
}
