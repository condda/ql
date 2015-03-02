using AST.Nodes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Visitors;
using AST.Storage;
using AST.Resources;
using AST.Nodes.Values;
using AST.Nodes.Arithmetic;

namespace AST.Evaluation
{
    //Precondition: typesafeness
    public class ArithmeticVisitor : BaseVisitor<int>
    {
        IDictionary<string, IValue> identifierLookup;

        public ArithmeticVisitor(IDictionary<string, IValue> identifierLookup)
        {
            this.identifierLookup = identifierLookup;
        }
        public override int Visit(Add node)
        {
            int left = node.Accept(this);
            int right = node.Accept(this);

            return left + right;
        }
        public override int Visit(Subtract node)
        {
            int left = node.Accept(this);
            int right = node.Accept(this);

            return left - right;
        }
        public override int Visit(Divide node)
        {
            int left = node.Accept(this);
            int right = node.Accept(this);

            return base.Visit(node);
        }
        public override int Visit(Multiply node)
        {
            int left = node.Accept(this);
            int right = node.Accept(this);

            return left * right;
        }
        public override int Visit(Id node)
        {
            return Lookup(identifierLookup[node.identifier]);
        }
        public override int Visit(Container node)
        {
            throw new NotImplementedException();
            //return 0 base.Visit(node);
        }



        //maybe make this into a visitor?
            private int Lookup(Int id)
            {
                return id.Value;
            }
            //TypeCheck just in case
            private int Lookup(IValue id)
            {
                throw new InvalidOperationException(
                    "identifier should refer to an AST.Nodes.Int, instead it refered to " + 
                    id.ToString()
                );
            }
            private int retrieveFromContainer(Int node)
            {
                throw new NotImplementedException();
            }
            private IValue retrieveFromContainer(IValue node)
            {
                throw new InvalidOperationException(
                    "identifier should refer to an AST.Nodes.Int, instead it refered to " +
                    node.ToString()
                    );
            }
        /////////////////////////////////

    }
}
