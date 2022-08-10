using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest_Service
{
    public interface IRepositoryWrapper
    {
        User GetUser(int id);
    }
}
