using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.CustomControls
{
    class CustomDatePicker : DatePicker, ICustomControl
    {
        #region Constructor
        public CustomDatePicker() { }
        #endregion

        #region ICustomControl
        public void AddConditionalEvent()
        {
            this.SelectedDateChanged += CustomDatePicker_SelectedDateChanged;
        }
        #endregion

        #region Conditional Events
        void CustomDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
