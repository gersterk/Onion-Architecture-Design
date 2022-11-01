using ArchitectureDesign.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureDesign.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string? Surname { get; set; }
    }
}
