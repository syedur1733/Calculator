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
        public List<string> mainList = new List<string>();
        public List<string> numberList = new List<string>();
        public List<string> operatorList = new List<string>();
        private int result;

        public int ProcessList(List<string> mainList)
        {
            foreach (var list in mainList)
            {
                bool response = int.TryParse(list, out result);
                if (response == false)
                {
                    operatorList.Add(list);
                }
                else
                {
                    numberList.Add(list);
                }
            }

            if (operatorList.Count > 0 && numberList.Count > 0)
            {
                return 2;
            }
            return 0;
        }

        public int Operation(List<string> numberList, List<string> operationList)
        {
            //numberList = numberList.Reverse();
            
            if (operationList.Count == 1)
            {
                result = Convert.ToInt32(numberList[0]) + Convert.ToInt32(numberList[0]);
            }
            return result;
        }

        static void Main(string[] args)
        {
            
        }
    }

    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ProcessTest()
        {
            List<string> mainList = new List<string>();
            mainList.Add("2");
            mainList.Add("3");
            mainList.Add("+");

            List<string> numberList = new List<string>();
            List<string> operatorList = new List<string>();
            
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.ProcessList(mainList));
        }

        [Test]
        public void OperationTest()
        {
            List<string> mainList = new List<string>();
            mainList.Add("2");
            mainList.Add("3");
            mainList.Add("+");
            
            List<string> numberList = new List<string>();
            List<string> operatorList = new List<string>();

            Calculator calculator = new Calculator();
            calculator.ProcessList(mainList);

            Assert.AreEqual(5, calculator.Operation(numberList, operatorList));
        }
    }
}
