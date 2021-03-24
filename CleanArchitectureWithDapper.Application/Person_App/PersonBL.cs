using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitectureWithDapper.Core.DTOs;
using CleanArchitectureWithDapper.Core.Entities;
using CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf;
using Microsoft.Extensions.Configuration;

namespace CleanArchitectureWithDapper.Application.Person_App
{
    public class PersonBL : IPersonBL
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public PersonBL(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<int> AddAsync(Person person)
        {
            var personId = await unitOfWork.PersonRepository.AddAsync(person);
            unitOfWork.Complete();
            return personId;
        }

        public async Task<int> AddWithPhonesAsync(PersonWithPhonesDTO personWithPhonesDTO)
        {
            Person person = new Person();
            mapper.Map(personWithPhonesDTO, person);
            var personId = await unitOfWork.PersonRepository.AddAsync(person);
            foreach (var phone in personWithPhonesDTO.PhonesList)
            {
                phone.IdPerson = personId;
                await unitOfWork.PhoneRepository.AddAsync(phone);
            }
            unitOfWork.Complete();
            return personId;
        }
    }
}
