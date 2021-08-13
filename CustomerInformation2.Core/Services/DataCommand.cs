using System;
using System.Threading.Tasks;
using CustomerInformation2.Core.Interfaces;

namespace CustomerInformation2.Core.Services
{
    public class DataCommand : IDataCommand
    {
        public DataCommand(DbContext<CusotmerInformationContext>)
        {

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
