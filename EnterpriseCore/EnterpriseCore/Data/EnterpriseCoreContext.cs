using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnterpriseCore.Models;

namespace EnterpriseCore.Data
{
    public class EnterpriseCoreContext : DbContext
    {
        public EnterpriseCoreContext (DbContextOptions<EnterpriseCoreContext> options)
            : base(options)
        {
        }

        public DbSet<EnterpriseCore.Models.EnterpriseTechnology> EnterpriseTechnology { get; set; }
    }
}
