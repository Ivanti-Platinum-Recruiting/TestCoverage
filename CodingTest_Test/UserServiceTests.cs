using NUnit.Framework;

namespace CodingTest
{
	[TestFixture]
	public class UserServiceTests
	{
		[Test]
		public void GetUser_ValidId_ReturnsAppropriateUsername()
		{
			// TODO: this function needs to be modified to make the test succeed consistently.
			
			UserService service = new UserService();
			string user = service.GetUsername(1);

			// this line cannot be modified
			Assert.AreEqual("Paul Smith", user, "Should return the appropriate user name.");
		}

		// add missing tests to reach full coverage
	}
}
