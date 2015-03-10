﻿using AST.Nodes;
using AST.Nodes.FormObject;
using AST.Representation;
using AST.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.TypeCheck.Collectors
{
    public class IdentifierTypeCollector : BaseVisitor<IList<NameToType>>
    {
        public override IList<NameToType> Visit(Form node)
        {
            return node.getChildren()
                       .SelectMany(x => x.Accept(this))
                       .ToList();
        }
        public override IList<NameToType> Visit(Question node)
        {
            return new List<NameToType> { new NameToType(node.Identifier, node.Type) };
        }

        public override IList<NameToType> Visit(Conditional node)
        {
            return node.Body
                       .SelectMany(x => x.Accept(this))
                       .ToList();
        }

    }
}
