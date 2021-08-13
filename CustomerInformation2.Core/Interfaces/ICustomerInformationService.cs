using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInformation2.Core.Entities;
namespace CustomerInformation2.Core.Interfaces
{
    public interface ICustomerInformationService 
    {
        Task<List<User>> GetAllCustomersAsync();
        Task<User> GetCustomerByIdAsync();
        Task<User> AddCustomerAsync();

    }
}
