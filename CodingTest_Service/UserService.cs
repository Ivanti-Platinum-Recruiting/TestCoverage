using CodingTest_Service;
using System;

namespace CodingTest
{
	/// <summary>
	/// This class can be modified.
	/// </summary>
	public class UserService
	{
		public string GetUsername(int userId)
		{
			if (userId < 0)
				return "User does not exist";

			UserRepository m_userRepository = new UserRepository();
			User user = m_userRepository.GetUser(userId);
			
			if ("Admin".Equals(user.LastName))
				throw new AccessViolationException();

			return $"{user.FirstName} {user.LastName}";
		}
	}
}
