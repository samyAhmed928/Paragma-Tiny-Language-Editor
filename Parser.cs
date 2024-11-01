using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tiny_language_project
{

    //Program ---> Functions Main_function


    public class Node
    {
        public List<Node> Children = new List<Node>();

        public string Name;
        public Node(string N)
        {
            this.Name = N;
        }
    }
    public class Parser
    {
        int InputPointer = 0;
        List<Token> TokenStream;
        public Node root;

        public Node StartParsing(List<Token> TokenStream)
        {
            this.InputPointer = 0;
            this.TokenStream = TokenStream;
            root = new Node("Program");
            root.Children.Add(Program());
            return root;
        }

        //cecking part
        bool checkTerm(int InputPtr)
        {
            if ((InputPtr < TokenStream.Count &&
                (TokenStream[InputPtr].token_type == Token_Class.Number ||
                 TokenStream[InputPtr].token_type == Token_Class.Idenifier)
                ) || (InputPtr < TokenStream.Count - 1 &&
                    (TokenStream[InputPtr].token_type == Token_Class.Idenifier &&
                    TokenStream[InputPtr + 1].token_type == Token_Class.LParanthesis)
                    )
                ) { return true; }
            return false;
        }

        bool checkFunCall()
        {
            if (InputPointer < TokenStream.Count - 1 &&
                (TokenStream[InputPointer].token_type == Token_Class.Idenifier &&
                TokenStream[InputPointer + 1].token_type == Token_Class.LParanthesis)
              )
            {
                return true;
            }
            return false;
        }

        bool checkEquation(int inputPtr)
        {
            if (checkFunCall() || checkTerm(inputPtr) || (inputPtr < TokenStream.Count &&
                        TokenStream[inputPtr].token_type == Token_Class.LParanthesis))
            {
                return true;
            }
            return false;
        }

        bool checkAssign()
        {
            if (InputPointer < TokenStream.Count - 1 &&
                (TokenStream[InputPointer].token_type == Token_Class.Idenifier &&
                TokenStream[InputPointer + 1].token_type == Token_Class.Assignment_op
                ))
            { return true; }
            return false;
        }


        Token_Class[] datatypes = { Token_Class.Int, /*Token_Class.Float,*/ Token_Class.Float, /*Token_Class.c,*/ Token_Class.String };
        Token_Class[] Optypes = { Token_Class.GreaterThanOp, Token_Class.LessThanOp, Token_Class.EqualOp, Token_Class.NotEqualOp };
        Token_Class[] ArthOptypes = { Token_Class.PlusOp, Token_Class.MinusOp, Token_Class.MultiplyOp, Token_Class.DivideOp };


        bool checkCond()
        {
            if (
                (InputPointer < TokenStream.Count - 2 && (
                    TokenStream[InputPointer].token_type == Token_Class.Idenifier &&
                    Optypes.Contains(TokenStream[InputPointer + 1].token_type) &&
                    TokenStream[InputPointer + 2].token_type == Token_Class.Number ||
                    TokenStream[InputPointer + 2].token_type == Token_Class.Idenifier)

                ) || (InputPointer < TokenStream.Count - 3 && (
                    TokenStream[InputPointer].token_type == Token_Class.Idenifier &&
                    Optypes.Contains(TokenStream[InputPointer + 1].token_type) &&
                    TokenStream[InputPointer + 2].token_type == Token_Class.Idenifier &&
                    TokenStream[InputPointer + 3].token_type == Token_Class.LParanthesis)
                )
             )
            { return true; }
            return false;
        }


        //1.Function_Call start
        Node Function_Call()
        {
            Node fncall = new Node("Function_Call");
            if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && TokenStream[InputPointer + 1].token_type == Token_Class.LParanthesis &&
              InputPointer < TokenStream.Count)
            {
                fncall.Children.Add(match(Token_Class.Idenifier));
                fncall.Children.Add(match(Token_Class.LParanthesis));
                fncall.Children.Add(Parameter_functioncall());
                fncall.Children.Add(match(Token_Class.RParanthesis));
            }
            return fncall;

        }


        // 1.1 Parameter_functioncal
        Node Parameter_functioncall()
        {
            Node parm = new Node("Parameter_functioncall");
            if (checkTerm(InputPointer))
            {

                parm.Children.Add(Term());
                parm.Children.Add(Call());
            }
            else
                return null;

            return parm;
        }

        // 1.2 call
        Node Call()
        {
            Node call = new Node("Call");
            if (InputPointer < TokenStream.Count - 1 &&
            TokenStream[InputPointer].token_type == Token_Class.Comma &&
            checkTerm(InputPointer + 1)
            )
            {
                call.Children.Add(match(Token_Class.Comma));
                call.Children.Add(Term());
                call.Children.Add(Call());
            }
            else
            {
                return null;
            }

            return call;
        }
        /*Node Id()
        {
            Node id = new Node("id");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Comma && InputPointer < TokenStream.Count)
                {
                    id.Children.Add(match(Token_Class.Comma));
                    if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                    {
                        id.Children.Add(match(Token_Class.Idenifier));
                        id.Children.Add(Id());
                    }
                    else if (TokenStream[InputPointer].token_type == Token_Class.Number && InputPointer < TokenStream.Count)
                    {
                        id.Children.Add(match(Token_Class.Number));
                        id.Children.Add(Id());
                    }
                }
                else
                {
                    return null;
                }
            }
            return id;
        }

        Node Function_Call()
        {
            Node funcall = new Node("funcall");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                {
                    funcall.Children.Add(match(Token_Class.Idenifier));
                    funcall.Children.Add(match(Token_Class.LParanthesis));
                    if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                    {
                        funcall.Children.Add(match(Token_Class.Idenifier));
                        funcall.Children.Add(Id());
                        funcall.Children.Add(match(Token_Class.RParanthesis));
                    }
                    else if (TokenStream[InputPointer].token_type == Token_Class.Number && InputPointer < TokenStream.Count)
                    {
                        funcall.Children.Add(match(Token_Class.Number));
                        funcall.Children.Add(Id());
                        funcall.Children.Add(match(Token_Class.RParanthesis));
                    }
                }
            }
            return funcall;
        }*/
        //1.Function_Call end



        // terminal Arithmatic_Operator +|-|*|/
        Node Arithmatic_Operator()
        {
            Node arith_Op = new Node("Arithmatic_Operator ");
            if ((TokenStream[InputPointer].token_type == Token_Class.PlusOp && InputPointer < TokenStream.Count))
            {
                arith_Op.Children.Add(match(Token_Class.PlusOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.MinusOp && InputPointer < TokenStream.Count)
            {
                arith_Op.Children.Add(match(Token_Class.MinusOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.MultiplyOp && InputPointer < TokenStream.Count)
            {
                arith_Op.Children.Add(match(Token_Class.MultiplyOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.DivideOp && InputPointer < TokenStream.Count)
            {
                arith_Op.Children.Add(match(Token_Class.DivideOp));

            }
            return arith_Op;

        }
        //terminal Arithmatic_Operator +|-|*|/ end

        //2.Equation start
        /*  Node Equation()
          {
              Node equ = new Node("Equation");
              equ.Children.Add(Terms_before_operator());
              if (TokenStream[InputPointer].token_type == Token_Class.LParanthesis && InputPointer < TokenStream.Count)
              {
                  equ.Children.Add(match(Token_Class.LParanthesis));
                  equ.Children.Add(Equation());
                  equ.Children.Add(match(Token_Class.RParanthesis));
                  equ.Children.Add(Terms_after_operator());
                  return equ;
              }
              else
              {
                  equ.Children.Add(Term());
                  return equ;
              }

          }

          //2.1Terms_after_operator
          Node Terms_after_operator()
          {
              Node tao = new Node("Terms_after_operator ");
              if (TokenStream[InputPointer].token_type == Token_Class.LParanthesis && InputPointer < TokenStream.Count)
              {
                  tao.Children.Add(match(Token_Class.LParanthesis));
                  tao.Children.Add(Arithmatic_Operator());
                  tao.Children.Add(Term());
                  tao.Children.Add(Terms_after_operator());
                  tao.Children.Add(match(Token_Class.RParanthesis));
                  return tao;
              }
              else
              {
                  return null;
              }

          }
          //2.2 Terms_before_operator
          Node Terms_before_operator()
          {
              Node tbo = new Node("Terms_before_operator ");
              if (TokenStream[InputPointer].token_type == Token_Class.LParanthesis && InputPointer < TokenStream.Count)
              {
                  tbo.Children.Add(match(Token_Class.LParanthesis));
                  tbo.Children.Add(Term());
                  tbo.Children.Add(Arithmatic_Operator());
                  tbo.Children.Add(Terms_before_operator());
                  tbo.Children.Add(match(Token_Class.RParanthesis));
                  return tbo;
              }
              else
              {
                  return null;
              }

          }*/
        //2.Equation end
        Node Equation_1()
        {
            Node x = new Node("Equation_1");
            if (InputPointer < TokenStream.Count)
            {

                if (InputPointer < TokenStream.Count &&
                ArthOptypes.Contains(TokenStream[InputPointer].token_type)
                )
                {
                    x.Children.Add(Arithmatic_Operator());
                    x.Children.Add(Equation());
                }
                else if (InputPointer < TokenStream.Count() &&
                     TokenStream[InputPointer].token_type != Token_Class.Semicolon
                    )
                {
                    x.Children.Add(Equation());

                }
            }
            return x;

        }

        Node Equation()
        {
            Node x = new Node("Equation");
            if (InputPointer < TokenStream.Count)
            {
                if (checkFunCall())
                {
                    x.Children.Add(Function_Call());
                    x.Children.Add(Equation_1());
                }
                else if (checkTerm(InputPointer))
                {
                    x.Children.Add(Term());
                    x.Children.Add(Equation_1());
                }

                else if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.LParanthesis)
                {
                    x.Children.Add(match(Token_Class.LParanthesis));

                    x.Children.Add(Equation());
                    x.Children.Add(match(Token_Class.RParanthesis));
                    x.Children.Add(Equation_1());

                }
            }
            return x;
        }


        //3.Term start
        Node Term()
        {
            Node term = new Node("Term ");
            if ((TokenStream[InputPointer].token_type == Token_Class.Number && InputPointer < TokenStream.Count))
            {
                term.Children.Add(match(Token_Class.Number));
            }
            else if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
            {
                term.Children.Add(match(Token_Class.Idenifier));
            }
            else
            {
                term.Children.Add(Function_Call());
            }
            return term;

        }
        //3.Term end

        //4.Expression start
        Node Expression()
        {
            Node exp = new Node("Expression ");
            if (InputPointer < TokenStream.Count)
            {

                if (checkEquation(InputPointer))
                {
                    exp.Children.Add(Equation());
                }
                else if (checkTerm(InputPointer))
                {
                    exp.Children.Add(Term());
                }
                else if (TokenStream[InputPointer].token_type == Token_Class.String && InputPointer < TokenStream.Count)
                {
                    exp.Children.Add(match(Token_Class.String));
                }
            }
            return exp;
        }
        //4.Expression end

        //5.Assignment_Statement start
        Node Assignment_Statement()
        {
            Node assign = new Node("Assignment_Statement");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && TokenStream[InputPointer + 1].token_type == Token_Class.Assignment_op)
                {
                    assign.Children.Add(match(Token_Class.Idenifier));
                    assign.Children.Add(match(Token_Class.Assignment_op));
                    assign.Children.Add(Expression());
                    assign.Children.Add(match(Token_Class.Semicolon));
                }
            }

            return assign;

        }
        //5.Assignment_Statement end

        //6.DataType start
        Node Datatype()
        {
            Node DT = new Node("Datatype");
            if ((TokenStream[InputPointer].token_type == Token_Class.Int && InputPointer < TokenStream.Count))
            {
                DT.Children.Add(match(Token_Class.Int));
            }
            else if ((TokenStream[InputPointer].token_type == Token_Class.Float && InputPointer < TokenStream.Count))
            {
                DT.Children.Add(match(Token_Class.Float));
            }
            else if (TokenStream[InputPointer].token_type == Token_Class.String && InputPointer < TokenStream.Count)
            {
                DT.Children.Add(match(Token_Class.String));
            }
            return DT;

        }
        //6.DataType end

        //7.Declaration_Statement start
        Node Declaration_Statement()
        {
            Node Declaration = new Node("Declaration");
            if (InputPointer < TokenStream.Count)
            {
                Declaration.Children.Add(Datatype());
                if ((TokenStream[InputPointer].token_type == Token_Class.Idenifier && TokenStream[InputPointer + 1].token_type == Token_Class.Assignment_op && InputPointer < TokenStream.Count))
                {
                    Declaration.Children.Add(match(Token_Class.Idenifier));
                    Declaration.Children.Add(match(Token_Class.Assignment_op));
                    Declaration.Children.Add(Expression());
                }
                else if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                {
                    Declaration.Children.Add(match(Token_Class.Idenifier));
                }
                Declaration.Children.Add(Decl_Stat());
                Declaration.Children.Add(match(Token_Class.Semicolon));
            }
            return Declaration;

        }

        //7.1 Decl_Stat
        Node Decl_Stat()
        {
            Node Decl = new Node("Decl_Stat");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Comma && InputPointer < TokenStream.Count)
                {
                    Decl.Children.Add(match(Token_Class.Comma));
                    if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                    {
                        Decl.Children.Add(match(Token_Class.Idenifier));
                    }
                    else if ((TokenStream[InputPointer].token_type == Token_Class.Idenifier && TokenStream[InputPointer + 1].token_type == Token_Class.Assignment_op && InputPointer < TokenStream.Count))
                    {
                        Decl.Children.Add(match(Token_Class.Idenifier));
                        Decl.Children.Add(match(Token_Class.Assignment_op));
                        Decl.Children.Add(Expression());

                    }
                    Decl.Children.Add(Decl_Stat());
                }
                else
                {
                    return null;
                }
            }
            return Decl;

        }
        //7.2 Decl_List
        /* Node Decl_List()
         {
             Node List = new Node("Decl_List");
             if (TokenStream[InputPointer].token_type == Token_Class.Idenifier  && InputPointer < TokenStream.Count)
             {
                 List.Children.Add(match(Token_Class.Idenifier));
             }
             else if((TokenStream[InputPointer].token_type == Token_Class.Idenifier && TokenStream[InputPointer + 1].token_type == Token_Class.Assignment_op && InputPointer < TokenStream.Count))
             {
                 List.Children.Add(match(Token_Class.Idenifier));
                 List.Children.Add(match(Token_Class.Assignment_op));
                 List.Children.Add(Expression());
             }
             return List;

         }*/

        //7.3 Assignment
        /* Node Assignment()
         {
             Node Assign = new Node("Assignment");
             if (TokenStream[InputPointer].token_type == Token_Class.Assignment_op)
             {

                 Assign.Children.Add(match(Token_Class.Assignment_op));
                 Assign.Children.Add(Expression());
             }
             return Assign;
         }*/

        //7.Declaration_Statement end

        //8.Write_Statement start
        Node Write_Statement()
        {
            Node writes = new Node("Write_Statement");
            if (InputPointer < TokenStream.Count)
            {

                if (TokenStream[InputPointer].token_type == Token_Class.Write)
                {
                    writes.Children.Add(match(Token_Class.Write));
                    if (TokenStream[InputPointer].token_type == Token_Class.Endl && InputPointer < TokenStream.Count)
                    {
                        writes.Children.Add(match(Token_Class.Endl));
                        writes.Children.Add(match(Token_Class.Semicolon));
                    }
                    else
                    {
                        writes.Children.Add(Expression());
                        writes.Children.Add(match(Token_Class.Semicolon));
                    }
                }
            }
            return writes;
        }

        //8.1 Writestat
        Node Writestat()
        {
            Node write = new Node("Writestat");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Endl && InputPointer < TokenStream.Count)
                {
                    write.Children.Add(match(Token_Class.Endl));
                    write.Children.Add(match(Token_Class.Semicolon));
                }
                else
                {
                    write.Children.Add(Expression());
                    write.Children.Add(match(Token_Class.Semicolon));
                }
            }
            return write;
        }
        //8.Write_Statement end


        // 9 & 10 9.Read_Statement  10.Return_Statement start

        //9 Read_Statement
        Node Read_Statement()
        {
            Node read = new Node("Read_Statement");

            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Read)
                {
                    read.Children.Add(match(Token_Class.Read));
                    read.Children.Add(match(Token_Class.Idenifier));
                    read.Children.Add(match(Token_Class.Semicolon));
                }
            }
            return read;
        }
        //10 Return_Statement
        Node Return_Statement()
        {
            Node retu = new Node("Return_Statement");
            if (InputPointer < TokenStream.Count)
            {
                if (TokenStream[InputPointer].token_type == Token_Class.Return)
                {
                    retu.Children.Add(match(Token_Class.Return));
                    retu.Children.Add(Expression());
                    retu.Children.Add(match(Token_Class.Semicolon));
                }
            }
            return retu;
        }
        // 9 & 10 9.Read_Statement  10.Return_Statement end


        //11.Condition_Operator start
        Node Condition_Operator()
        {
            Node Conditiono = new Node("Condition_Operator");
            if ((TokenStream[InputPointer].token_type == Token_Class.LessThanOp && InputPointer < TokenStream.Count))
            {
                Conditiono.Children.Add(match(Token_Class.LessThanOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.GreaterThanOp && InputPointer < TokenStream.Count)
            {
                Conditiono.Children.Add(match(Token_Class.GreaterThanOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.EqualOp && InputPointer < TokenStream.Count)
            {
                Conditiono.Children.Add(match(Token_Class.EqualOp));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.NotEqual && InputPointer < TokenStream.Count)
            {
                Conditiono.Children.Add(match(Token_Class.NotEqual));

            }
            return Conditiono;

        }
        //11.Condition_Operator end

        // 12. Condition start
        Node Condition()
        {
            Node cond = new Node("Condition");
            if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.Idenifier)
            {
                cond.Children.Add(match(Token_Class.Idenifier));
                cond.Children.Add(Condition_Operator());
                cond.Children.Add(Term());
            }
            return cond;
        }
        // 12. Condition end

        //13.Boolean_Operator start
        Node Boolean_Operator()
        {
            Node Booleano = new Node("Boolean_Operator");
            if ((TokenStream[InputPointer].token_type == Token_Class.And_op && InputPointer < TokenStream.Count))
            {
                Booleano.Children.Add(match(Token_Class.And_op));

            }
            else if (TokenStream[InputPointer].token_type == Token_Class.OR_op && InputPointer < TokenStream.Count)
            {
                Booleano.Children.Add(match(Token_Class.OR_op));

            }
            return Booleano;
        }
        //13.Boolean_Operator end


        // 14.Condition_Statement start
        Node Condition_Statement()
        {
            Node con = new Node("Condition_Statement");
            con.Children.Add(Condition());
            con.Children.Add(Bool());
            return con;
        }

        //14.1 Bool
        Node Bool()
        {
            Node bo = new Node("Bool");
            if (InputPointer < TokenStream.Count)
            {

                if (InputPointer < TokenStream.Count && (TokenStream[InputPointer].token_type == Token_Class.And_op || TokenStream[InputPointer].token_type == Token_Class.OR_op))
                {
                    bo.Children.Add(Boolean_Operator());
                    bo.Children.Add(Condition());
                    bo.Children.Add(Bool());
                }
                else
                {
                    return null;
                }
            }
            return bo;
        }
        // 14.Condition_Statement end



        // 15.If_Statement start
        Node If_Statement()
        {
            Node IF = new Node("If_Statement");
            if (InputPointer < TokenStream.Count)
            {
                IF.Children.Add(match(Token_Class.If));
                IF.Children.Add(Condition_Statement());
                IF.Children.Add(match(Token_Class.Then));
                IF.Children.Add(Statement());
                if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.Elseif)
                {

                    IF.Children.Add(Else_If_Statement());
                }
                else if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.Else)
                {

                    IF.Children.Add(Else_Statement());
                }
                else if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.End)
                {

                    IF.Children.Add(match(Token_Class.End));
                }
            }

            return IF;

        }

        //15.1 Statements
        Node Statements()
        {
            Node statx = new Node("Statements");
            if (InputPointer < TokenStream.Count)
            {
                statx.Children.Add(Statement());
                statx.Children.Add(Statements_if());
            }
            return statx;

        }
        //15.2 Statements_if
        Node Statements_if()
        {
            Node statx = new Node("Statementsx");
            if ((TokenStream[InputPointer].Equals(Statement()) && InputPointer < TokenStream.Count))
            {
                statx.Children.Add(Statement());
                statx.Children.Add(Statements_if());
            }
            else
            {
                return null;
            }
            return statx;

        }

        //15.3 End
        //Note that we use End with 16.Else_If_Statement
        Node End()
        {
            Node end = new Node("End");
            if ((TokenStream[InputPointer].token_type == Token_Class.Elseif && InputPointer < TokenStream.Count))
            {
                end.Children.Add(Else_If_Statement());
            }
            else if ((TokenStream[InputPointer].token_type == Token_Class.Else && InputPointer < TokenStream.Count))
            {
                end.Children.Add(Else_Statement());
            }
            else if ((TokenStream[InputPointer].token_type == Token_Class.End && InputPointer < TokenStream.Count))
            {
                end.Children.Add(match(Token_Class.End));
            }
            return end;
        }
        // 15.If_Statement end

        // 16 & 17  16.Else_If_Statement  & 17.Else_Statement start
        Node Else_If_Statement()
        {
            Node eif = new Node("Else_If_Statement");
            if (InputPointer < TokenStream.Count)
            {
                eif.Children.Add(match(Token_Class.Elseif));
                eif.Children.Add(Condition_Statement());
                eif.Children.Add(match(Token_Class.Then));
                eif.Children.Add(Statement());
                if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.Elseif)
                {

                    eif.Children.Add(Else_If_Statement());
                }
                else if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.Else)
                {

                    eif.Children.Add(Else_Statement());
                }
                else if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type == Token_Class.End)
                {

                    eif.Children.Add(match(Token_Class.End));
                }
            }
            return eif;

        }

        Node Else_Statement()
        {
            Node els = new Node("Else_Statement");
            if (InputPointer < TokenStream.Count)
            {
                els.Children.Add(match(Token_Class.Else));
                if (InputPointer < TokenStream.Count && TokenStream[InputPointer].token_type != Token_Class.End)
                {
                    els.Children.Add(Statement());
                }
                els.Children.Add(match(Token_Class.End));
            }
            return els;

        }
        // 16 & 17  16.Else_If_Statement  & 17.Else_Statement end

        // 18.Repeat_Statement start
        Node Repeat_Statement()
        {
            Node Repeat = new Node("Repeat_Statement");
            Repeat.Children.Add(match(Token_Class.Repeat));
            Repeat.Children.Add(Statement());
            Repeat.Children.Add(match(Token_Class.Until));
            Repeat.Children.Add(Condition_Statement());

            return Repeat;

        }
        // 18.Repeat_Statement end

        // 19. FunctionName start
        Node FunctionName()
        {
            Node Fn = new Node("FunctionName");
            Fn.Children.Add(match(Token_Class.Idenifier));
            return Fn;
        }
        // 19.FunctionName end


        //20.Parameter start
        Node Parameter()
        {
            Node para = new Node("Parameter");
            if (InputPointer < TokenStream.Count)
            {
                para.Children.Add(Datatype());
                para.Children.Add(match(Token_Class.Idenifier));
            }
            return para;
        }
        //20.Parameter end

        // 21.Function_Declaration start
        Node Function_Declaration()
        {
            Node funkdec = new Node("Function_Declaration");
            if (InputPointer < TokenStream.Count - 1 &&
                 (datatypes.Contains(TokenStream[InputPointer].token_type) &&
                   TokenStream[InputPointer].token_type == Token_Class.Idenifier &&
                   TokenStream[InputPointer + 1].token_type == Token_Class.LParanthesis))
            {
                funkdec.Children.Add(Datatype());
                funkdec.Children.Add(FunctionName());
                funkdec.Children.Add(match(Token_Class.LParanthesis));
                funkdec.Children.Add(Parameters());
                funkdec.Children.Add(match(Token_Class.RParanthesis));
            }
            return funkdec;
        }

        // 21.1 Parameters
        Node Parameters()
        {
            Node parm = new Node("Parameters");
            if (InputPointer < TokenStream.Count)
            {
                if (InputPointer < TokenStream.Count - 1 && datatypes.Contains(TokenStream[InputPointer].token_type) &&
                                    TokenStream[InputPointer + 1].token_type == Token_Class.Idenifier)
                {
                    parm.Children.Add(Parameter());
                    parm.Children.Add(Parameters_declararion());
                }
                else
                {
                    return null;
                }
            }
            return parm;

        }


        // 21.2 Parameters_declararion
        Node Parameters_declararion()
        {
            Node psx = new Node("Parametersx");
            if (InputPointer < TokenStream.Count)
            {

                if (InputPointer < TokenStream.Count - 2 && TokenStream[InputPointer].token_type == Token_Class.Comma &&
                datatypes.Contains(TokenStream[InputPointer + 1].token_type) &&
                  TokenStream[InputPointer + 2].token_type == Token_Class.Idenifier)
                {
                    psx.Children.Add(match(Token_Class.Comma));
                    psx.Children.Add(Parameter());
                    psx.Children.Add(Parameters_declararion());
                }
                else
                {
                    return null;
                }
            }
            return psx;
        }
        // 21.Function_Declaration end


        // 22.Function_Body start
        Node Function_Body()
        {
            Node fb = new Node("Function_Body");
            if (InputPointer < TokenStream.Count)
            {
                fb.Children.Add(match(Token_Class.LCurlyBrackets));
                fb.Children.Add(Statement());
                //fb.Children.Add(Return_Statement());
                fb.Children.Add(match(Token_Class.RCurlyBrackets));
            }
            return fb;

        }
        // 22.Function_Body end

        // 23.Function_Statement start
        Node Function_Statement()
        {
            Node fstat = new Node("Function_Statement");
            if (InputPointer < TokenStream.Count)
            {
                if (InputPointer < TokenStream.Count - 2 &&
                 (datatypes.Contains(TokenStream[InputPointer].token_type) &&
                   TokenStream[InputPointer + 1].token_type == Token_Class.Idenifier &&
                   TokenStream[InputPointer + 2].token_type == Token_Class.LParanthesis))
                {
                    fstat.Children.Add(Function_Declaration());
                }
                fstat.Children.Add(Function_Body());
            }
            return fstat;

        }
        // 23.Function_Statement end

        //24.Main_Function start
        Node Main_Function()
        {
            Node mainf = new Node("Main_Function");
            if (InputPointer < TokenStream.Count)
            {
                if (datatypes.Contains(TokenStream[InputPointer].token_type))
                {
                    mainf.Children.Add(Datatype());
                }

                mainf.Children.Add(match(Token_Class.Main));
                mainf.Children.Add(match(Token_Class.LParanthesis));
                mainf.Children.Add(match(Token_Class.RParanthesis));
                mainf.Children.Add(Function_Body());
            }

            return mainf;
        }
        //24.Main_Function end

        //25.Program start
        Node Program()
        {
            Node prog = new Node("Program");
            if (InputPointer < TokenStream.Count &&
                TokenStream[InputPointer].token_type == Token_Class.Comment)
            {
                prog.Children.Add(match(Token_Class.Comment));
            }

            prog.Children.Add(M_function());
            return prog;
        }



        Node M_function()
        {
            Node x = new Node("Functions");
            if (InputPointer < TokenStream.Count)
            {
                x.Children.Add(Functions());
                if (InputPointer < TokenStream.Count &&
                  TokenStream[InputPointer].token_type == Token_Class.Comment)
                {
                    x.Children.Add(match(Token_Class.Comment));
                }
                x.Children.Add(Main_Function());
            }
            return x;
        }





        //25.1 Functions

        Node Functions()
        {
            Node x = new Node("funAboveMain");
            if (InputPointer < TokenStream.Count - 1 && datatypes.Contains(TokenStream[InputPointer].token_type) &&
                TokenStream[InputPointer + 1].token_type != Token_Class.Main
                )
            {

                if (InputPointer < TokenStream.Count - 2 &&
                (datatypes.Contains(TokenStream[InputPointer].token_type) &&
                  TokenStream[InputPointer + 1].token_type == Token_Class.Idenifier &&
                  TokenStream[InputPointer + 2].token_type == Token_Class.LParanthesis))
                {
                    x.Children.Add(Datatype());
                    x.Children.Add(match(Token_Class.Idenifier));
                    x.Children.Add(match(Token_Class.LParanthesis));
                    x.Children.Add(Parameters());
                    x.Children.Add(match(Token_Class.RParanthesis));

                }

                x.Children.Add(Function_Body());

                x.Children.Add(Functions());

            }
            return x;
        }
        /*Node Functions()
         {
             Node func = new Node("Functions");
             if (InputPointer < TokenStream.Count)
             {
                 func.Children.Add(Function_Statement());
                 func.Children.Add(Functions());
                 return func;
             }
             else
             {
                 return null;
             }
         }*/
        //25.Program end




        Node Statement()
        {
            Node statementss = new Node("statement");
            if (InputPointer < TokenStream.Count)
            {
                //Write_Statement
                if (TokenStream[InputPointer].token_type == Token_Class.Write && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(Write_Statement());
                    statementss.Children.Add(Statement());
                }
                else if (TokenStream[InputPointer].token_type == Token_Class.Comment && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(match(Token_Class.Comment));
                    statementss.Children.Add(Statement());

                }
                //Read_Statement
                else if (TokenStream[InputPointer].token_type == Token_Class.Read && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(Read_Statement());
                    statementss.Children.Add(Statement());
                }
                //Return_Statement
                else if (TokenStream[InputPointer].token_type == Token_Class.Return && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(Return_Statement());
                    statementss.Children.Add(Statement());
                }
                //Repeat_statement
                else if (TokenStream[InputPointer].token_type == Token_Class.Repeat && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(Repeat_Statement());
                    statementss.Children.Add(Statement());
                }
                //If_statement
                else if (TokenStream[InputPointer].token_type == Token_Class.If && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(If_Statement());
                    statementss.Children.Add(Statement());
                }
                //Assignment_statement
                else if (TokenStream[InputPointer].token_type == Token_Class.Idenifier && InputPointer < TokenStream.Count)
                {
                    statementss.Children.Add(Assignment_Statement());
                    statementss.Children.Add(Statement());
                }
                else if (TokenStream[InputPointer].token_type == Token_Class.Int && InputPointer < TokenStream.Count ||
                         TokenStream[InputPointer].token_type == Token_Class.Float && InputPointer < TokenStream.Count ||
                         TokenStream[InputPointer].token_type == Token_Class.String && InputPointer < TokenStream.Count)
                {
                    if (TokenStream[InputPointer + 1].token_type == Token_Class.Idenifier)
                    {
                        //Function_Statement();
                        if (TokenStream[InputPointer + 2].token_type == Token_Class.LParanthesis && InputPointer - 2 < TokenStream.Count)
                        {
                            statementss.Children.Add(Function_Statement());
                            statementss.Children.Add(Statement());
                        }
                        //Declaration_statement();
                        else if (InputPointer - 1 < TokenStream.Count)
                        {
                            statementss.Children.Add(Declaration_Statement());
                            statementss.Children.Add(Statement());
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            return statementss;
        }

        public Node match(Token_Class ExpectedToken)
        {

            if (InputPointer < TokenStream.Count)
            {
                if (ExpectedToken == TokenStream[InputPointer].token_type)
                {
                    InputPointer++;
                    Node newNode = new Node(ExpectedToken.ToString());

                    return newNode;

                }

                else
                {
                    Errors.Error_List.Add("Parsing Error: Expected "
                        + ExpectedToken.ToString() + " and " +
                        TokenStream[InputPointer].token_type.ToString() +
                        "  found\r\n");
                    InputPointer++;
                    return null;
                }
            }
            else
            {
                Errors.Error_List.Add("Parsing Error: Expected "
                        + ExpectedToken.ToString() + "\r\n");
                InputPointer++;
                return null;
            }
        }

        public static TreeNode PrintParseTree(Node root)
        {
            TreeNode tree = new TreeNode("Parse Tree");
            TreeNode treeRoot = PrintTree(root);
            if (treeRoot != null)
                tree.Nodes.Add(treeRoot);
            return tree;
        }
        static TreeNode PrintTree(Node root)
        {
            if (root == null || root.Name == null)
                return null;
            TreeNode tree = new TreeNode(root.Name);
            if (root.Children.Count == 0)
                return tree;
            foreach (Node child in root.Children)
            {
                if (child == null)
                    continue;
                tree.Nodes.Add(PrintTree(child));
            }
            return tree;
        }
    }
}

