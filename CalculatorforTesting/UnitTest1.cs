
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Calculator;
namespace CalculatorforTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c; 
        public TestContext testContext;
        public TestContext TestContext { get; set; }
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
        // connectiong data project
        
        [TestMethod]// testcase 1
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestAddDatasource()
        {
            int a, b, expected, actual; // ket qua thuc te va kết quả mong đợi
            a = int.Parse(testContext.DataRow[0].ToString());
            b = int.Parse(testContext.DataRow[1].ToString());
            expected = int.Parse(testContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        
    }
}
