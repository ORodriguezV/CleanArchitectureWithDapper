using CleanArchitectureWithDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDapper.Core.DTOs
{
    public class PersonWithPhonesDTO : Person
    {
        public List<Phone> PhonesList { get; set; }
    }
}
