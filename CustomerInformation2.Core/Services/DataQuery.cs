using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInformation2.Core.Interfaces;

namespace CustomerInformation2.Core.Services
{
    public class DataQuery : IDataQuery 
    {
        public DataQuery()
        {
        }

        public Task<List<User>> Get(int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
