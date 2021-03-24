using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDapper.Core.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public string Number { get; set; }
    }
}
