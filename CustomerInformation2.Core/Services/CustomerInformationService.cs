using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInformation2.Core.DTO;
using CustomerInformation2.Core.Interfaces;

namespace CustomerInformation2.Core.Services
{
    public class CustomerInformationService : ICustomerInformationService
    {
        private readonly IDataQuery _dataQuery;
        private readonly IDataCommand _dataCommand;

        public CustomerInformationService(IDataQuery dataQuery, IDataCommand dataCommand)
        {
            _dataQuery = dataQuery;
            _dataCommand = dataCommand;
        }

        public async Task<User> AddCustomerAsync(CustomerRequst cusotmerRequest)
        {
            var record = await _dataCommand.
            throw new NotImplementedException();
        }

        public Task<User> AddCustomerAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetCustomerByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
