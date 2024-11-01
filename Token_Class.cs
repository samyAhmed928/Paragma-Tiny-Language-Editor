using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_language_project
{
	public enum Token_Class
	{
		Int, Float, String, Read, Write, Repeat, Until, If, Elseif, Else, End, Then, Return, Endl, Main,
		Dot, Semicolon, Comma, LSquareBrackets, RSquareBrackets, LCurlyBrackets, RCurlyBrackets, LParanthesis, RParanthesis, EqualOp, LessThanOp,
		GreaterThanOp, NotEqualOp, PlusOp, MinusOp, MultiplyOp, DivideOp, Assignment_op, NotEqual, And_op, OR_op
		, Idenifier, Number, Comment

	}
}
