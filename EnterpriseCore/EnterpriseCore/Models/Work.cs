using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseCore.Models
{
    public class Work : BaseEntity
    {
        public List<Applicant> Applicants { get; set; }
        public WorkStatus Status{ get; set; }
        public List<Effort> Efforts { get; set; }

    }
}
