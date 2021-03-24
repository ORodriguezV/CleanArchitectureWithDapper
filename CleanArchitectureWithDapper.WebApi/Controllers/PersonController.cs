using CleanArchitectureWithDapper.Application.Person_App;
using CleanArchitectureWithDapper.Core.DTOs;
using CleanArchitectureWithDapper.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBL personBL;

        public PersonController(IPersonBL personBL)
        {
            this.personBL = personBL;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Person person)
        {
            return Ok(await personBL.AddAsync(person));
        }

        [HttpPost("AddWithPhones")]
        public async Task<IActionResult> AddWithPhones(PersonWithPhonesDTO personWithPhones)
        {
            return Ok(await personBL.AddWithPhonesAsync(personWithPhones));
        }

    }
}
