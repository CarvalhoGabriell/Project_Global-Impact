using FIAP.Global_ImpactWeb.Models;
using FIAP.Global_ImpactWeb.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Cadastrar(Doacao doacao)
        {
            _context.Doacoes.Add(doacao);
            
            
        }
        public int Contar()
        {
           return _context.Doacoes.Count();
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
