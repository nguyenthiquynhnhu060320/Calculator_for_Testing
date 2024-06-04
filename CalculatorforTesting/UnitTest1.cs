
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace CalculatorforTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]// 1 testcase 1
        public void TestAddoperator()
        {
            int expected, actual; // kết quả mong đợi
            Calculation c = new Calculation(10,1);
            expected = 11;
            actual = 11;
            Assert.AreEqual(expected, actual);
        }
    }
}
