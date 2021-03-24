using CleanArchitectureWithDapper.Infrastructure.Repositories.Person_Inf;
using CleanArchitectureWithDapper.Infrastructure.Repositories.Phones_Inf;
using System;

namespace CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository PersonRepository { get; }
        IPhoneRepository PhoneRepository { get; }
        void Complete();
    }
}
