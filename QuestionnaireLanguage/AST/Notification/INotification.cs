using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Notification
{
    interface INotification
    {
        int LineNumber();
        int StartCharacterPosition();
        int EndCharacterPosition();
        string Message();
    }
}
