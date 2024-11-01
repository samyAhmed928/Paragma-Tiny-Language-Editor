using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_language_project
{
    internal class Compiler
    {
        public static Scanner scanner = new Scanner();
        public static Parser Tiny_Parser = new Parser();
        public static Node treeroot;
        public static List<string> Lexemes = new List<string>();
        public static List<Token> TokenStream = new List<Token>();
        

        public static void Start_Compiling(string SourceCode) //character by character
        {
            //Scanner

            scanner.StartScanning(SourceCode);
            //Parser
            Tiny_Parser.StartParsing(TokenStream);
            treeroot = Tiny_Parser.root;
        }





    }
}

