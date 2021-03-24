using CleanArchitectureWithDapper.Application.Phones_App;
using CleanArchitectureWithDapper.Core.Entities;
using CleanArchitectureWithDapper.Infrastructure.UnitOfWork_Inf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureWithDapper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IPhonesBL phonesBL;

        public PhonesController(IPhonesBL phonesBL)
        {
            this.phonesBL = phonesBL;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Phone phone)
        {
            return Ok(await phonesBL.AddAsync(phone));
        }

    }
}
