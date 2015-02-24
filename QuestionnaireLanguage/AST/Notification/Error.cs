using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST.Notification
{
    public class Error : INotification
    {
        private int lineNumber;
        private int startCharPos;
        private int endCharPos;
        private string ErrorDescription;

        public Error(int lineNumber, int startCharPos, int endCharPos, 
                     string ErrorDescription = "No Error Description available")
        {
            this.lineNumber = lineNumber;
            this.startCharPos = startCharPos;
            this.endCharPos = endCharPos;
            this.ErrorDescription = ErrorDescription;
        }

        public int LineNumber()
        {
            return lineNumber;
        }

        public int StartCharacterPosition()
        {
            return startCharPos;
        }

        public int EndCharacterPosition()
        {
            return endCharPos;
        }

        public string Message()
        {
            return ErrorDescription;
        }
    }
}
