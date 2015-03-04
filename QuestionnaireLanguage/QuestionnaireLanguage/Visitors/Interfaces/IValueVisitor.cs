﻿using QuestionnaireLanguage.GUI.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Values = AST.Nodes.Values;
using Labels = AST.Nodes.Labels;

namespace QuestionnaireLanguage.Visitors.Interfaces
{
    public interface IValueVisitor
    {
        StringTextBoxWidget Visit(Values.String question);
        IntegerTextBoxWidget Visit(Values.Int conditional);
        CheckboxWidget Visit(Values.Bool conditional);
        LabelWidget Visit(Labels.Label value);
    }
}