using CleanArchitectureWithDapper.Core.Entities;
using CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.Application.Phones_App
{
    public class PhonesBL : IPhonesBL
    {
        private readonly IUnitOfWork unitOfWork;

        public PhonesBL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<int> AddAsync(Phone phone)
        {
            var data = await unitOfWork.PhoneRepository.AddAsync(phone);
            unitOfWork.Complete();
            return data;
        }

    }
}
