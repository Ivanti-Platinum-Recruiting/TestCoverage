using CodingTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest_Service
{
    public class TestingRepositoryWrapper : IRepositoryWrapper
    {
        private TestingUserRepository _repo;

        public TestingRepositoryWrapper(TestingUserRepository repo) // could have a separate one for UserRepository
        {
            _repo = repo;
        }

        public User GetUser(int id)
        {
            return _repo.GetUser(id);
        }
    }
}
