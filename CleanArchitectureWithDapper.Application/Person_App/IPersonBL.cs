using CleanArchitectureWithDapper.Core.DTOs;
using CleanArchitectureWithDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.Application.Person_App
{
    public interface IPersonBL
    {
        Task<int> AddAsync(Person person);

        Task<int> AddWithPhonesAsync(PersonWithPhonesDTO personWithPhonesDTO);
    }
}
