using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInformation2.Core;
using CustomerInformation2.Core.Interfaces;
using CustomerInformation2.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation2.Infrastructure.Data
{
    public class DataCommand : IDataCommand
    {
        private readonly CustomerInformationContext _dbContext;
        public DataCommand(CustomerInformationContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<T> AddAsync<T>(T entity) where T : class
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public Task DeleteAsync<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChangesAsync();
        }

        public async Task<User> Delete(int projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Post(int projectId, string searchString)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Put(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
