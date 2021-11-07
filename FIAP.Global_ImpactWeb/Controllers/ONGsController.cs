using FIAP.Global_ImpactWeb.Models;
using FIAP.Global_ImpactWeb.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Controllers
{
    public class ONGsController : Controller
    {
        private SolutionContext _context;

        public ONGsController(SolutionContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var busca = _context.Users.ToList();
            return View(busca);
        }


        [HttpGet]
        public IActionResult Cadastrar(int id)
        {
            CarregarNomesBancos();
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(UserONG ong)
        {
            _context.Users.Add(ong);
            _context.SaveChanges();
            TempData["msg"] = "Cadastro realizado com sucesso!";
            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarNomesBancos();
            return View();
        }

        [HttpPost]
        public IActionResult Editar(UserONG ong)
        {
            _context.Users.Update(ong);
            _context.SaveChanges();
            TempData["msg"] = "Edição realizado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
           var ong =  _context.Users.Find(id);
            _context.Users.Remove(ong);
            TempData["msg"] = "ONG Removida com sucesso!";
            return RedirectToAction("Index");
        }

        public void CarregarNomesBancos()
        {
            var nomes = new List<string>(new string[] 
            {"Santander","Nubank","Banco Inter","Bradesco","Banco Neon","Banco do Brasil","Itaú","C6 Bank"});

            // mandar pra view como um select
            ViewBag.bancos = new SelectList(nomes);
        }
    }
}
