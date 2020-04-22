using DemoCore.Application;
using DemoCore.Service.Model;
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
            this.personRepositoryMock = new PersonRepositoryMock();
            this.myApplication = new MyApplication(this.personRepositoryMock);
        }

        [Test]
        public void RegisterPerson()
        {
            Person person = new Person
            {
                id = 1,
                name = "Name",
                age = 30,
                address = "address"
            };

            Person result = this.myApplication.Register("Name", 30, "address");

            Assert.AreEqual(person, result);
        }
    }
}