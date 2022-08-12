using CodingTest_Service;
using NUnit.Framework;
using System;

namespace CodingTest
{
	[TestFixture]
	public class UserServiceTests
	{
		private UserService _service;

		[SetUp]
        public void Setup()
        {
            var wrapper = new TestingRepositoryWrapper(new TestingUserRepository());
            _service = new UserService(wrapper);
        }

		[Test]
		public void GetUser_ValidId_ReturnsAppropriateUsername()
		{
			string user = _service.GetUsername(1);

			// this line cannot be modified
			Assert.AreEqual("Paul Smith", user, "Should return the appropriate user name.");
		}

		// add missing tests to reach full coverage

		[Test]
        public void GetUser_IdBelowZero_ReturnsErrorString()
        {
            string msg = _service.GetUsername(-1);

            Assert.AreEqual(ErrorMessages.USER_DOES_NOT_EXIST, msg);
        }

        [Test]
        public void GetUser_IdIsZero_ReturnUsername()
        {
            string user = _service.GetUsername(0);

            Assert.AreEqual("Terry Turquoise", user);
        }

        [Test]
        public void GetUser_AdminUser_ThrowsAccessViolationException()
        {
            Assert.Throws<AccessViolationException>(() => _service.GetUsername(2));
        }

        [Test]
        public void GetUser_GenuineUserWithAdminSurname_ReturnsAppropriateUsername()
        {
            string user = _service.GetUsername(4);

            Assert.AreEqual("Adam Admin", user);
        }

        [Test]
        public void GetUser_IdDoesntExist_ReturnsErrorString()
        {
            string msg = _service.GetUsername(3);

            Assert.AreEqual(ErrorMessages.USER_DOES_NOT_EXIST, msg);
        }
		
        [Test]
        public void GetUser_ReturnsWithSpaceBetweenFirstAndLastNames()
        {
            var name = "John Black"; // default name minus space
            string user = _service.GetUsername(99);

            Assert.AreEqual(name, user);
        }
    }
}
