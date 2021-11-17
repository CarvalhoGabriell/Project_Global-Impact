using FIAP.Global_ImpactWeb.Models;
using FIAP.Global_ImpactWeb.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Repositories
{
    public class DoacaoRepository : IDoacaoRepository
    {
        private SolutionContext _context;

        public DoacaoRepository(SolutionContext context)
        {
            _context = context;
        }

        public IList<Doacao> BuscarPor(Expression<Func<Doacao, bool>> filtro)
        {
            return _context.Doacoes.Where(filtro).ToList();
        }

        public void Cadastrar(Doacao doacao)
        {
            _context.Doacoes.Add(doacao);
            
        }

        public int Contar()
        {
           return _context.Doacoes.Count();
        }

        public int Contar(Expression<Func<Doacao, bool>> filtro)
        {
            return _context.Doacoes.Where(filtro).Count();
        }

        public IList<Doacao> Listar()
        {
           return _context.Doacoes.ToList();
        }

        public void SaveCommit()
        {
            _context.SaveChanges();
        }
    }
}
