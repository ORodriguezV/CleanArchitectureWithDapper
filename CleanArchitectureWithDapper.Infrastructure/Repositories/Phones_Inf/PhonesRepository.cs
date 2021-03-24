using CleanArchitectureWithDapper.Core.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.Infrastructure.Repositories.Phones_Inf
{
    public class PhoneRepository : RepositoryBase, IPhoneRepository
    {

        public PhoneRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<int> AddAsync(Phone entity)
        {
            var result = await Connection.QuerySingleAsync<int>(@"
                Insert into Phone (IdPerson, Number) Output Inserted.Id VALUES (@IdPerson, @Number)",
                entity, Transaction, null, CommandType.Text);
            return result;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Phone>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Phone> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Phone entity)
        {
            throw new NotImplementedException();
        }
    }
}
