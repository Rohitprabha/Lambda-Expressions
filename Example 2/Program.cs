using System;
using System.Collections.Generic;

namespace Lambda_Expressions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            List<int> resultUsingExpressionLambda = list.FindAll(p => p < 3);
            Console.WriteLine("Using expressions lambda: ");
            foreach (int item in resultUsingExpressionLambda)
            {
                Console.WriteLine(item);
            }
            List<int> resultUsingStatementLambda = list.FindAll(p =>
            {
                return p < 3;
            });
            Console.WriteLine("Using statements lambda: ");
            foreach (int item in resultUsingStatementLambda)
            {
                Console.WriteLine(item);
            }
        }
    }
}
