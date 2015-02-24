using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST.Representation
{
    public class Identifier : IEquatable<Identifier>
    {
        private string name;
        private ObjectType type;

        bool IEquatable<Identifier>.Equals(Identifier other)
        {
            if (other == null)
                return false;

            return other.name == name &&
                   other.type == type;
        }

        public Identifier(string name, ObjectType type)
        {
            this.name = name;
            this.type = type;
        }

        public string GetName(){ return name; }
        public ObjectType GetType() { return type; }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;

            Identifier other = obj as Identifier;
            if((System.Object)other == null)
                return false;

 	        return other.name == name && 
                   other.type == type;
        }
    }
}
