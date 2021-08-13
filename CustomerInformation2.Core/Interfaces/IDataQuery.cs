using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerInformation2.Core.Interfaces
{
    public interface IDataQuery
    {
        Task<List<User>> Get(int projectId);
        Task<User> GetById(int projectId);

    }
}
