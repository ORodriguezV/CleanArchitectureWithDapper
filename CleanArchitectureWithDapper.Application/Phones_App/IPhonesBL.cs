using CleanArchitectureWithDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.Application.Phones_App
{
    public interface IPhonesBL
    {
        Task<int> AddAsync(Phone phone);
    }
}
