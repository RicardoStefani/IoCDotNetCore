using DemoCore.Application;
using DemoCore.Interface;
using NUnit.Framework;

namespace NUnitTestDemoCore
{
    public class MyApplicationTest
    {
        private ICalc myServiceMock;

        private MyApplication myApplication;

        [SetUp]
        public void Setup()
        {
            this.myApplication = new MyApplication(myServiceMock);
        }

        [Test]
        public void Test1()
        {
            //this.myApplication.Call();
            Assert.Pass();
        }
    }
}