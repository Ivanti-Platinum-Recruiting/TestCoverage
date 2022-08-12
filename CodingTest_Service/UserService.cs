using CodingTest_Service;
using System;

namespace CodingTest
{
	/// <summary>
	/// This class can be modified.
	/// </summary>
	public class UserService
	{
		private IRepositoryWrapper _wrapper;

		public UserService(IRepositoryWrapper wrapper)
		{
			_wrapper = wrapper;
		}

		public string GetUsername(int userId)
		{
			if (userId < 0)
				return ErrorMessages.USER_DOES_NOT_EXIST;

			var user = _wrapper.GetUser(userId);

			if (user == null)
				return ErrorMessages.USER_DOES_NOT_EXIST;
			
			if ("Admin".Equals(user.LastName) && string.IsNullOrEmpty(user.FirstName))
				throw new AccessViolationException();

			return $"{user.FirstName} {user.LastName}";
		}
	}
}
