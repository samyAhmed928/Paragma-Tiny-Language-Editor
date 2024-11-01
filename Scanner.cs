using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_language_project
{

    public class Token
    {
        public string lexim;
        public Token_Class token_type;
    }
    public class Scanner
    {
        public List<Token> Tokens = new List<Token>();
        Dictionary<string, Token_Class> ReservedWords = new Dictionary<string, Token_Class>();
        Dictionary<string, Token_Class> Operators = new Dictionary<string, Token_Class>();
        public Scanner()
        {
            #region Add ReservedWords to ReservedWords list
            ReservedWords.Add("int", Token_Class.Int);
            ReservedWords.Add("float", Token_Class.Float);
            ReservedWords.Add("string", Token_Class.String);
            ReservedWords.Add("read", Token_Class.Read);
            ReservedWords.Add("write", Token_Class.Write);
            ReservedWords.Add("repeat", Token_Class.Repeat);
            ReservedWords.Add("main", Token_Class.Main);
            ReservedWords.Add("until", Token_Class.Until);
            ReservedWords.Add("if", Token_Class.If);
            ReservedWords.Add("elseif", Token_Class.Elseif);
            ReservedWords.Add("else", Token_Class.Else);
            ReservedWords.Add("end", Token_Class.End);
            ReservedWords.Add("then", Token_Class.Then);
            ReservedWords.Add("return", Token_Class.Return);
            ReservedWords.Add("endl", Token_Class.Endl);
            #endregion

            #region Add operators to operators list
            //punction Operators
            //Operators.Add(".", Token_Class.Dot);
            Operators.Add(";", Token_Class.Semicolon);
            Operators.Add(",", Token_Class.Comma);
            Operators.Add("(", Token_Class.LParanthesis);
            Operators.Add(")", Token_Class.RParanthesis);
            Operators.Add("[", Token_Class.LSquareBrackets);
            Operators.Add("]", Token_Class.RSquareBrackets);
            Operators.Add("{", Token_Class.LCurlyBrackets);
            Operators.Add("}", Token_Class.RCurlyBrackets);
            //Logical OPerators
            Operators.Add("=", Token_Class.EqualOp);
            Operators.Add("<", Token_Class.LessThanOp);
            Operators.Add(">", Token_Class.GreaterThanOp);
            Operators.Add(":=", Token_Class.Assignment_op);
            Operators.Add("<>", Token_Class.NotEqual);
            Operators.Add("&&", Token_Class.And_op);
            Operators.Add("||", Token_Class.And_op);
            //Mathmitcal OPerators
            Operators.Add("+", Token_Class.PlusOp);
            Operators.Add("-", Token_Class.MinusOp);
            Operators.Add("*", Token_Class.MultiplyOp);
            Operators.Add("/", Token_Class.DivideOp);
            #endregion


        }
        public void StartScanning(string SourceCode)
        {
            SourceCode = SourceCode + " ";
            for (int i = 0; i < SourceCode.Length; i++)
            {
                int j = i;
                char CurrentChar = SourceCode[i];
                string CurrentLexeme = CurrentChar.ToString();

                if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                {
                    continue;
                }

                #region Identifier Scanning
                if (char.IsLetter(CurrentChar))
                {
                    j = i + 1;
                    CurrentChar = SourceCode[j];
                    if (j < SourceCode.Length)
                    {
                        while ((CurrentChar >= 'A' && CurrentChar <= 'z') || (CurrentChar >= '0' && CurrentChar <= '9'))
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];

                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }

                //else if (CurrentChar >= '0' && CurrentChar <= '9')
                //{
                //    j = i + 1;
                //    CurrentChar = SourceCode[j];
                //    if (j < SourceCode.Length)
                //    {
                //        while ((CurrentChar >= 'A' && CurrentChar <= 'z') || (CurrentChar >= '0' && CurrentChar <= '9'))
                //        {
                //            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                //            j++;
                //            CurrentChar = SourceCode[j];

                //        }
                //    }
                //    FindTokenClass(CurrentLexeme);
                //    i = j - 1;
                //}
                #endregion

                #region Constant Scaning
                else if (CurrentChar >= '0' && CurrentChar <= '9')
                {
                    j = i + 1;
                    CurrentChar = SourceCode[j];
                    if (j < SourceCode.Length)
                    {

                            while ((CurrentChar >= '0' && CurrentChar <= '9') || (CurrentChar == '.'))
                            {
                                CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                                j++;
                                CurrentChar = SourceCode[j];
                            }

                         while ((CurrentChar >= 'A' && CurrentChar <= 'z') || (CurrentChar >= '0' && CurrentChar <= '9'))
                         {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];

                         }


                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }
                #endregion

                #region Comment Scaning
                else if (CurrentChar == '/')
                {
                    CurrentChar = SourceCode[++j];
                    if (CurrentChar == '*')
                    {
                        CurrentLexeme += CurrentChar.ToString();
                        ++j;
                        while (j < SourceCode.Length)
                        {
                            CurrentChar = SourceCode[j];
                            CurrentLexeme += CurrentChar.ToString();
                            if (CurrentChar == '*' && j + 1 < SourceCode.Length && SourceCode[j + 1] == '/')
                            {
                                CurrentLexeme += SourceCode[j + 1].ToString();
                                j += 2;
                                break;
                            }
                            ++j;
                        }
                        i = j - 1;
                    }
                    FindTokenClass(CurrentLexeme);
                }
                #endregion
                else if (CurrentChar == '\"')
                {
                    j++;
                    while (j < SourceCode.Length)
                    {
                        CurrentChar = SourceCode[j];
                        CurrentLexeme += CurrentChar.ToString();
                        if (CurrentChar == '\"'/* && SourceCode[j - 1] != '\\'*/)
                        {
                            ++j;
                            break;
                        }
                        j++;
                    }
                    i = j - 1;
                    FindTokenClass(CurrentLexeme);
                }
                #region OPerators Scaning
                //Assignment operator (:=)
                else if (CurrentChar == ':')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '=')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }
                //Not Equal operator (<>)
                else if (CurrentChar == '<')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '>')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }
                else if (CurrentChar == '<')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '=')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }

                //Less than or equal operator (<=)
                else if (CurrentChar == '>')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '=')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }
                //
                //else if (CurrentChar == '.')
                //{
                //    j = i + 1;
                //    CurrentChar = SourceCode[j];
                //    if ((CurrentChar >= 'A' && CurrentChar <= 'Z') || (CurrentChar >= 'a' && CurrentChar <= 'z'))
                //    {
                //        FindTokenClass(CurrentLexeme);
                //        i = j - 1;
                //    }
                //    else
                //    {
                //        while (j < SourceCode.Length)
                //        {
                //            if (CurrentChar == ' ' || CurrentChar == '\n' || CurrentChar == '\r' || CurrentChar == '\t' || CurrentChar == ';')
                //            {
                //                FindTokenClass(CurrentLexeme);
                //                i = j - 1;
                //                break;
                //            }
                //            else
                //            {
                //                CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                //                j++;
                //                CurrentChar = SourceCode[j];
                //            }
                //        }
                //    }
                //}
                //AND operator (&&)
                else if (CurrentChar == '&')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '&')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }
                //OR operator (||)
                else if (CurrentChar == '|')
                {
                    if (j < SourceCode.Length)
                    {
                        j++;
                        CurrentChar = SourceCode[j];
                        if (CurrentChar == '|')
                        {
                            CurrentLexeme = CurrentLexeme + CurrentChar.ToString();
                            j++;
                            CurrentChar = SourceCode[j];
                        }
                    }
                    FindTokenClass(CurrentLexeme);
                    i = j - 1;
                }


                #endregion
                #region Other Catogries
                else
                {
                    FindTokenClass(CurrentLexeme);
                }
                #endregion
            }

            Compiler.TokenStream = Tokens;
        }
        void FindTokenClass(string Lex)
        {

            Token Tok = new Token();
            Tok.lexim = Lex;
            //Is it a reserved word?
            if (ReservedWords.ContainsKey(Lex))
            {
                Tok.token_type = ReservedWords[Lex];
                Tokens.Add(Tok);
            }

            //Is it an identifier?
            else if (isIdentifier(Lex))
            {
                Tok.token_type = Token_Class.Idenifier;
                Tokens.Add(Tok);
            }
            else if (isComment(Lex))
            {
                Tok.token_type = Token_Class.Comment;
                Tokens.Add(Tok);
            }
            else if (isString(Lex))
            {
                Tok.token_type = Token_Class.String;
                Tokens.Add(Tok);
            }
            //Is it a Number?
            else if (isConstant(Lex))
            {
                Tok.token_type = Token_Class.Number;
                Tokens.Add(Tok);
            }
            //Is it an operator?
            else if (Operators.ContainsKey(Lex))
            {
                Tok.token_type = Operators[Lex];
                Tokens.Add(Tok);
            }
            else
            {
                Errors.Error_List.Add("Unidentified Token " + Lex);
            }

        }



        bool isIdentifier(string lex)
        {

            Regex identifierRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*$");
            if (identifierRegex.IsMatch(lex))
            {
                return true;
            }
            return false;

        }

        bool isConstant(string lex)
        {
            //bool isValid = true;
            Regex constantRegex = new Regex(@"^[0-9]+(\.[0-9]*)?$");
            if (constantRegex.IsMatch(lex))
                return true;
            else
                return false;
            //return isValid;
        }
        bool isComment(string lex)
        {
            Regex commentRegex = new Regex(@"\A(/\*)[a-zA-Z0-9\s?\W?]+(\*/)\Z");
            if (commentRegex.IsMatch(lex))
                return true;
            else
                return false;
        }
        bool isString(string lex)
        {
            Regex StringRegex = new Regex(@"^""[a-zA-Z0-9\s?\W?]*""$");
            if (StringRegex.IsMatch(lex))
                return true;
            else
                return false;
        }
    }
}




