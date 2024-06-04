
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace CalculatorforTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c; 

        [TestInitialize] // thiết lập general database 
        public void Setup()
        {
            c = new Calculation (10, 5);
        }
        [TestMethod]// testcase 1
        public void TestAddoperator()
        {
            int expected, actual; // ket qua thuc te va kết quả mong đợi
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]// testcase 2
        public void TestSuboperator()
        {
            int expected, actual; // ket qua thuc te va kết quả mong đợi
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//  testcase 3
        public void TestMuloperator()
        {
            int expected, actual; // ket qua thuc te va kết quả mong đợi
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]// testcase 4
        public void TestDivoperator()
        {
            int expected, actual;
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
    }
}
