using AST.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Resources
{
    public class ValidKeyValuePairs
    {
        public Dictionary<string, ObjectType> ValidPairs = new Dictionary<string,ObjectType> {
            { "label" , ObjectType.String },
            { "value" , ObjectType.Anything },
            { "options", ObjectType.List}
        };


    }
}
