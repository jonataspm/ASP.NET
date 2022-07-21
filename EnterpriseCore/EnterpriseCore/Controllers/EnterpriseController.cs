using EnterpriseCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseCore.Controllers
{
    public class EnterpriseController : Controller
    {
        public IActionResult Index()
        {
            List<TechnologyType> types = new List<TechnologyType>();
            types.Add(TechnologyType.CSharp);
            types.Add(TechnologyType.SQL);

            List<Enterprise> enterprises = new List<Enterprise>();
            enterprises.Add(new Enterprise { Id = 1, Name = "Jhey's Company", Types = types });

            return View(enterprises);
        }
    }
}
