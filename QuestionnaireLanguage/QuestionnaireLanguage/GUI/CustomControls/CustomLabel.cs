using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.CustomControls
{
    class CustomLabel : Label, ICustomControl
    {
        #region Constructor
        public CustomLabel() { }
        #endregion

        #region ICustomControl
        public void AddConditionalEvent()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Conditional Events
        #endregion
    }
}
