using CleanArchitectureWithDapper.Infrastructure.Repositories.Person_Inf;
using CleanArchitectureWithDapper.Infrastructure.Repositories.Phones_Inf;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf
{
    public class UnitOfWork : IUnitOfWork
    {
        private IPersonRepository _personRepository;
        private IPhoneRepository _phoneRepository;
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public UnitOfWork(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IPersonRepository PersonRepository
        {
            get { return _personRepository ?? (_personRepository = new PersonRepository(_transaction)); }
        }

        public IPhoneRepository PhoneRepository
        {
            get { return _phoneRepository ?? (_phoneRepository = new PhoneRepository(_transaction)); }
        }

        public void Complete()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                resetRepositories();
            }
        }

        private void resetRepositories()
        {
            _personRepository = null;
            _phoneRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }

    }
}
