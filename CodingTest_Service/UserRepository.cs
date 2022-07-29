using CodingTest_Service;
using System;

namespace CodingTest
{
	/// <summary>This class must not be modified.</summary>
	public class UserRepository
	{
		/// <summary>Returns a random user from a static list.</summary>
		public User GetUser(int userId)
		{
			User[] users = {
				new User() { FirstName = "John", LastName = "Black"	},
				new User() { FirstName = "Jack", LastName = "White"	},
				new User() { FirstName = "Henri", LastName = "Brown" },
				new User() { LastName = "Admin" }
			};

			int randomIndex = new Random().Next(0, users.Length);

			return users[randomIndex];
		}
	}
}
