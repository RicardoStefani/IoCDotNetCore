using DemoCore.Application;
using NUnit.Framework;
using NUnitTestDemoCore.ServiceMock;

namespace NUnitTestDemoCore
{
    public class MyApplicationTest
    {
        private PersonRepositoryMock personRepositoryMock;

        private MyApplication myApplication;

        [SetUp]
        public void Setup()
        {
            this.myApplication = new MyApplication(personRepositoryMock);
        }

        [Test]
        public void Test1()
        {
            this.myApplication.Call();
            Assert.Pass();
        }
    }
}