using AST.Nodes.Values;
using QuestionnaireLanguage.GUI.Interfaces.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.CustomControls
{
    public class CustomCheckBox : CheckBox, ICustomControl
    {
        #region Constructors
        public CustomCheckBox() { }
        #endregion

        #region ICustomControl
        public void AddConditionalEvent()
        {
            this.Click += CustomCheckBox_Click;
        }

        #endregion

        #region Private Methods

        #endregion

        #region Conditional Events
        void CustomCheckBox_Click(object sender, RoutedEventArgs e)
        {
            //Evaluate the expression
            throw new NotImplementedException();
        }

        #endregion
    }
}
