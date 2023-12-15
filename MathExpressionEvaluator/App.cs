using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressionEvaluator
{
    public static class App
    {
        public static void Run(string[] args)
        {
           while (true)
            {
                Console.Write("Please enter math expression: ");
                var input = Console.ReadLine();
                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"Left Side = {expr.LeftSideOperand}, operation = {expr.Operation} , right = {expr.RightSideOperand}");
                Console.WriteLine($"{input} = {EvaluateExpresion(expr)}");
            }
        }

        private static object EvaluateExpresion(MathExpression expr)
        {
           if(expr.Operation == MathOperation.Addition)
                return expr.LeftSideOperand + expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Subtraction)
                return expr.LeftSideOperand - expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Multiplication)
                return expr.LeftSideOperand * expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Division)
                return expr.LeftSideOperand / expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Modulus)
                return expr.LeftSideOperand % expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Power)
                return Math.Pow(expr.LeftSideOperand , expr.RightSideOperand) ;
            else if (expr.Operation == MathOperation.Sin)
                return Math.Sin(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Cos)
                return Math.Cos(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Tan)
                return Math.Tan(expr.RightSideOperand);

            return 0;
        }
    }
}
