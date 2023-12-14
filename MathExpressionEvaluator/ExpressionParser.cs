using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionEvaluator
{
    internal static class ExpressionParser
    {
        private const string MathSymbols = "+*/%^";
        public static MathExpression Parse(string input)
        {
            var expr = new MathExpression();
            string token = "";
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    token += currentChar;
                } else if (MathSymbols.Contains(currentChar))
                {
                    expr.LeftSideOperand = double.Parse(token);
                    token = "";
                } else if (currentChar == '-')
                {
                     
                } else if (char.IsLetter(currentChar))
                {

                } else if (currentChar == ' ')
                {

                }else
                {

                }
            }
          

                return expr;
        }
    }
}
