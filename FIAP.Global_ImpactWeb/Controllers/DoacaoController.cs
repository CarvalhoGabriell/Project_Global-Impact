using FIAP.Global_ImpactWeb.Models;
using FIAP.Global_ImpactWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Controllers
{
    public class DoacaoController : Controller
    {
        private IDoacaoRepository _doacaoRepository;

        public DoacaoController(IDoacaoRepository doacaoRepository)
        {
            _doacaoRepository = doacaoRepository;
        }


        [HttpGet]
        public IActionResult Doar(int id)
        {
            ViewBag.ongs = id;
            return View();
        }

        [HttpPost]
        public IActionResult Doar(Doacao doacao)
        {
            _doacaoRepository.Cadastrar(doacao);
            _doacaoRepository.SaveCommit();
            TempData["msg"] = "Doação Realizada com Sucesso";
            return RedirectToAction("Index", "ONGs");
        }
    }
}
