using System;

namespace Day30Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Operators operators = new Operators();
            operators.AssignmentOperators();
            operators.ArithimenticOperator();
            operators.ComparisionOperators();
            operators.ConditionalOperator();
            operators.TernaryOperator();

            IfStatement ifStatement = new IfStatement();
            ifStatement.IfAndIfelseStatement();
            ifStatement.IfAndIfelseStatementExample();


            SwitchStatement switchStatement = new SwitchStatement();
            switchStatement.SwitchStatementExample1();
            switchStatement.SwitchStatementExample2();
            switchStatement.CoffeePerchagingExample();

            NULLCoalescingOperator nULLCoalescingOperator = new NULLCoalescingOperator();
            nULLCoalescingOperator.NULLCoalescingOperatorSimpleExample();
            nULLCoalescingOperator.NULLCoalescingOperatorComplexExample();

            WhileLoop whileLoop = new WhileLoop();
            whileLoop.WhileLoopExample();

            DoWhileLoop doWhileLoop = new DoWhileLoop();
            doWhileLoop.DoWhileLoopExample();
            doWhileLoop.DoWhileLoopExample1();
            doWhileLoop.BankingSystemExampleUsingDoWhileLoop();
            doWhileLoop.CoffeePerchagingExampleUsingDOWHILELoop();

            ForAndForeachLoop forAndForeachLoop = new ForAndForeachLoop();
            forAndForeachLoop.ForAndForeachLoopExample1();
            forAndForeachLoop.ForAndForeachLoopExample2();

            Methods.MethodExample1();
            Methods.MethodExample2();

            MethodParameters methodParameters = new MethodParameters();
            methodParameters.ValueParameters();
            methodParameters.ReferanceParameters();
            methodParameters.OutputMethodParameters();
            methodParameters.ParametersArrays();

            OutAndRefMethodParameters outAndRefMethodParameters = new OutAndRefMethodParameters();
            outAndRefMethodParameters.OutAndRefExample1();

            Tuples tuples = new Tuples();
            tuples.TuplesExample();

        }
    }
}
