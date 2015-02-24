using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST.Notification
{
    public class Warning : INotification
    {
        private int lineNumber;
        private int startCharPos;
        private int endCharPos;
        private string WarningDescription;

        public Warning(int lineNumber, int startCharPos, int endCharPos,
                     string WarningDescription = "No Warning Description available")
        {
            this.lineNumber = lineNumber;
            this.startCharPos = startCharPos;
            this.endCharPos = endCharPos;
            this.WarningDescription = WarningDescription;
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
            return WarningDescription;
        }
    }
}
