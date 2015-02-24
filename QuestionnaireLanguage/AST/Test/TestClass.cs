using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using AST.Nodes.Interfaces;
using AST.ParseTreeVisitors;
using Grammar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Test
{
    public class TestClass
    {
        public TestClass()
        {

        }

        public IASTNode GetAST(string path)
        {
            string program = File.ReadAllText(path);

            AntlrInputStream input = new AntlrInputStream(program);
            QLMainLexer lexer = new QLMainLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            QLMainParser parser = new QLMainParser(tokens);

            //remove standard Error Listener
            parser.RemoveErrorListeners();

            //Detect more errors (like ambiguousness errors)
            //parser.AddErrorListener(new DiagnosticErrorListener());

            //add standard error listener
            parser.AddErrorListener(new ParserErrorListener());

            IParseTree tree = parser.form();

            Console.WriteLine(tree.ToStringTree(parser));
            FormVisitor visitor = new FormVisitor();
            IASTNode ast = visitor.Visit(tree);

            return ast;
        }
    }
}
