using CodingTest;

namespace CodingTest_Service
{
	public class TestingUserRepository
	{
		public User GetUser(int userId)
		{
			switch (userId)
            {
				case 0:
					return new User() { FirstName = "Terry", LastName = "Turquoise" };
				case 1:
					return new User() { FirstName = "Paul", LastName = "Smith" };
				case 2:
					return new User() { LastName = "Admin" };
				case 3:
					return null;
				case 4:
					return new User() { FirstName = "Adam", LastName = "Admin" };
				default:
					return new User() { FirstName = "John", LastName = "Black" };
			}			
		}
	}
}
