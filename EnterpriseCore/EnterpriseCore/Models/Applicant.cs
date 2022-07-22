using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseCore.Models
{
    public class Applicant : BaseEntity
    {
        public string Name { get; set; }
        public List<ApplicantTechnology> TechnologyTypes { get; set; }

    }
}
