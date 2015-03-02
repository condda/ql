﻿using AST.Nodes.Interfaces;
using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AST.Resources;

namespace AST.Nodes.TypeName
{
    public class TypeName : IType
    {
        private string representation;
        private PositionInText position;
        private Types type;

        public TypeName(string representation, Types type, PositionInText position )
        {
            this.representation = representation;
            this.position = position;
            this.type = type;
        }

        public PositionInText GetPositionInText()
        {
            return position;
        }
    }
}
