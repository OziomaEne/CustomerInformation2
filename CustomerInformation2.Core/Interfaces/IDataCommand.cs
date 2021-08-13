using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerInformation2.Core.Interfaces
{
    public interface IDataCommand
    {
        Task<User> Post(int projectId, string searchString);
        Task<User> Put(int projectId);
        Task<User> Delete(int projectId);
    }
}
