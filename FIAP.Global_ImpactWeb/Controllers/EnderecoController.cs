using FIAP.Global_ImpactWeb.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Controllers
{
    public class EnderecoController : Controller
    {
        private SolutionContext _context;


        public EnderecoController(SolutionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
