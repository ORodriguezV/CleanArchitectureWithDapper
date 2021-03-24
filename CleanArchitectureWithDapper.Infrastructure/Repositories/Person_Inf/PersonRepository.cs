using CleanArchitectureWithDapper.Core.DTOs;
using CleanArchitectureWithDapper.Core.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.Infrastructure.Repositories.Person_Inf
{
    public class PersonRepository : RepositoryBase, IPersonRepository
    {

        public PersonRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public async Task<int> AddAsync(Person entity)
        {
            var result = await Connection.QuerySingleAsync<int>(@"
                Insert into Person (Firstname, Lastname) Output Inserted.Id Values (@Firstname, @Lastname);", 
                entity, Transaction, null, CommandType.Text);
            return result;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
