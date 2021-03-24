using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CleanArchitectureWithDapper.Infrastructure.Repositories
{
    public abstract class RepositoryBase
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }

        public RepositoryBase(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
