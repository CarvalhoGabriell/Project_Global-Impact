using FIAP.Global_ImpactWeb.Models;
using FIAP.Global_ImpactWeb.Persistencia;
using FIAP.Global_ImpactWeb.Repositories;
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
        private IONGRepository _ongRepository;

        private IDoacaoRepository _doacaoRepository;
        
        public ONGsController(IONGRepository ongRepository, IDoacaoRepository doacaoRepository)
        {
            _ongRepository = ongRepository;
            _doacaoRepository = doacaoRepository;
        }


        [HttpGet]
        public IActionResult Index(string nomeBuscado)
        {
            var busca = _ongRepository.BuscarPor(str => str.Nome.Contains(nomeBuscado) || nomeBuscado == null);
            return View(busca);
        }


        [HttpGet]
        public IActionResult IndexAdmin(string nomeOng)
        {
            var ongs = _ongRepository.BuscarPor(str => str.Nome.Contains(nomeOng) || nomeOng == null);
            return View(ongs);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarNomesBancos();
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(UserONG ong)
        {
            _ongRepository.Cadastro(ong);
            _ongRepository.SaveCommit();
            TempData["msg"] = "Cadastro realizado com sucesso!";
            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarNomesBancos();
            var ong = _ongRepository.BuscaPorId(id);
            return View(ong);
        }

        [HttpPost]
        public IActionResult Editar(UserONG ong)
        {

            _ongRepository.Atualizar(ong);
            _ongRepository.SaveCommit();
            TempData["msg"] = "Edição realizado com sucesso!";
            return RedirectToAction("IndexAdmin");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _ongRepository.Deletar(id);
            _ongRepository.SaveCommit();
            TempData["msg"] = "ONG Removida com sucesso!";
            return RedirectToAction("IndexAdmin");
        }

        
        // fazer o metodo para carregar a pagina de detalhes de cada ong
        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var ongs = _ongRepository.BuscaPorId(id);
            var doacao = _doacaoRepository.BuscarPor(f => f.CodigoId == id).ToList();
            var totalDoacao = _doacaoRepository.Contar(f=>f.CodigoId == id);
            ViewBag.total = totalDoacao;
            ViewBag.doacoes = doacao;
            return View(ongs);
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
