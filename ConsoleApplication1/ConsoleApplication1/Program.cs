using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSD
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            
        }

        public int ProcessList(string[] expression)
        {
            Stack<int> expressionStack = new Stack<int>();
            int op1, op2, result;
            
            if (expression.Length <= 0)
            {
                throw new Exception("Empty Array");
            }

            for (int i = 0; i < expression.Length; i++)
            {

                if (expression[i] == "+")
                {
                    op2 = Convert.ToInt32(expressionStack.Pop());
                    op1 = Convert.ToInt32(expressionStack.Pop());

                    result = op1 + op2;
                    expressionStack.Push(result);
                }
                else if (expression[i] == "-")
                {
                    op2 = Convert.ToInt32(expressionStack.Pop());
                    op1 = Convert.ToInt32(expressionStack.Pop());

                    result = op1 - op2;
                    expressionStack.Push(result);
                }
                else if (expression[i] == "*")
                {
                    op2 = Convert.ToInt32(expressionStack.Pop());
                    op1 = Convert.ToInt32(expressionStack.Pop());

                    result = op1 * op2;
                    expressionStack.Push(result);
                }
                else if (expression[i] == "/")
                {
                    op2 = Convert.ToInt32(expressionStack.Pop());
                    op1 = Convert.ToInt32(expressionStack.Pop());

                    result = op1 / op2;
                    expressionStack.Push(result);
                }
                else if (expression[i] == "%")
                {
                    op1 = Convert.ToInt32(expressionStack.Pop());

                    result = op1 / 100;
                    expressionStack.Push(result);
                }
                else
                {
                    expressionStack.Push(Convert.ToInt32(expression[i]));
                }
            }
            
            return expressionStack.Pop();
        }
    }

    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator = new Calculator();

        [Test]
        public void ProcessListAdditionTest1()
        {
            string[] expression = new string[] { "2", "3", "+" };
            Assert.AreEqual(5, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListAdditionTest2()
        {
            string[] expression = new string[] { "2", "3", "+", "5", "+" };
            Assert.AreEqual(10, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListAdditionTest3()
        {
            string[] expression = new string[] { "2", "+" };

            try
            {
                Assert.AreEqual(true, calculator.ProcessList(expression));
            }
            catch (Exception ex)
            {
                Assert.False(false);
            }
        }

        [Test]
        public void ProcessListDifferenceTest()
        {
            string[] expression = new string[] { "2", "3", "-" };
            Assert.AreEqual(-1, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListMultiplicationTest()
        {
            string[] expression = new string[] { "2", "3", "*" };
            Assert.AreEqual(6, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListDivisionTest()
        {
            string[] expression = new string[] { "6", "3", "/" };
            Assert.AreEqual(2, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListComplexTest()
        {
            string[] expression = new string[] { "2", "5", "8", "+", "-" };
            Assert.AreEqual(-11, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListEmptyTest1()
        {
            string[] expression = new string[] {};

            try
            {
                Assert.AreEqual(true, calculator.ProcessList(expression));
            }
            catch (Exception ex)
            {
                Assert.True(true);
            }
        }

        [Test]
        public void ProcessListEmptyTest2()
        {
            string[] expression = new string[] { "2", "3", "+"};

            try
            {
                Assert.AreEqual(true, calculator.ProcessList(expression));
            }
            catch (Exception ex)
            {
                Assert.False(false);
            }
        }

        [Test]
        public void ProcessListAdditionTest4()
        {
            string[] expression = new string[] { "1", "2", "3", "+", "-" };
            Assert.AreEqual(-4, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListAdditionTest5()
        {
            string[] expression = new string[] { "6", "2", "*", "3", "/" };
            Assert.AreEqual(4, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListAdditionTest6()
        {
            string[] expression = new string[] { "5", "1", "2", "+", "4", "*", "+", "3", "-" };
            Assert.AreEqual(14, calculator.ProcessList(expression));
        }

        [Test]
        public void ProcessListFactorTest()
        {
            string[] expression = new string[] { "100", "%", "2", "*" };
            Assert.AreEqual(2, calculator.ProcessList(expression));
        }
    }
}
