﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using AST;
using AST.Test;
using QuestionnaireLanguage.Controller;

namespace QuestionnaireLanguage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            string path =  @"C:\Users\Daniel\Documents\UVA\Software Construction\Assignments\project\many-ql\FelipezConde\testsamples\";
            string fileName = "test9.txt";

            TestClass test = new TestClass();
            ASTResult ast = test.GetAST(path + fileName);

            Processor proc = new Processor(ast);
            UIElement element = proc.ProcessAST();
            //this.AddChild(element);
            this._stack.Children.Add(element);

            //create GUI (ast, window)
            

            /*FormVisitor visitor = new FormVisitor();
            Console.WriteLine(visitor.Visit(tree));*/
        }
    }
}
