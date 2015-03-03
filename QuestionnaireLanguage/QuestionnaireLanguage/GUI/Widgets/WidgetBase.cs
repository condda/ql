using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuestionnaireLanguage.GUI.Widgets
{
    public abstract class WidgetBase
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
