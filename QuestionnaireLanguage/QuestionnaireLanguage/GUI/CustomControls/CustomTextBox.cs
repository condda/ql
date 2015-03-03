using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuestionnaireLanguage.GUI.CustomControls
{
    public class CustomTextBox : TextBox, ICustomControl
    {
        #region Constructors
        public CustomTextBox(bool isNumeric)
        {
            if (isNumeric)
                this.PreviewTextInput += new TextCompositionEventHandler(Validate_Numeric);
        }

        #endregion

        #region ICustomControl

        public void AddConditionalEvent()
        {
            this.LostKeyboardFocus += Lost_Focus;
        }

        public void AddConditionalEvent(ICustomControlVisitor visitor)
        {
            this.LostKeyboardFocus += Lost_Focus;
            //visitor.Visit(this);
        }


        #endregion

        #region ValidationEvents
        private void Validate_Numeric(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!int.TryParse(e.Text, out result))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region ConditionalEvents
        private void Lost_Focus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //TODO: Implement conditional
            int result;
        }

        #endregion
    }
}
