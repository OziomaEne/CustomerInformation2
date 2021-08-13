using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInformation2.Core;
using CustomerInformation2.Core.Interfaces;
using CustomerInformation2.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation2.Infrastructure.Data
{
    public class DataQuery : IDataQuery
    {
        private readonly CustomerInformationContext _dbContext;
        public DataQuery(CustomerInformationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<T>> ListAsync<T>() where T : class
        {
            return _dbContext.Set<T>().ToListAsync();
        }


        public async Task<List<User>> Get(int projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
