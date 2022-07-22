using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseCore.Models
{
    public class Enterprise : BaseEntity
    {
        public string Name{ get; set; }
        public List<EnterpriseTechnology> TechnologyTypes { get; set; }

        public List<Work> Works { get; set; }
    }
}
