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
    public class ONGRepository : IONGRepository
    {
        private SolutionContext _context;

        public ONGRepository(SolutionContext context)
        {
            _context = context;
        }
        public void Atualizar(UserONG ong)
        {
            _context.Users.Update(ong);
        }

        public UserONG BuscaPorId(int id)
        {
            return _context.Users.Where(o => o.CodigoId == id)
                .Include(f => f.Endereco)
                .Include(f=>f.Conta)
                .FirstOrDefault();
           
        }

        public IList<UserONG> BuscarPor(Expression<Func<UserONG, bool>> filtro)
        {
            return _context.Users.Where(filtro)
                .Include(f=>f.Endereco)
                .Include(f=>f.Conta)
                .ToList();
        }

        public void Cadastro(UserONG ong)
        {
            _context.Users.Add(ong);
        }

        public void Deletar(int id)
        {
            var busca = _context.Users.Find(id);
            _context.Users.Remove(busca);
        }

        public IList<UserONG> Listar()
        {
            return _context.Users.ToList();
        }

        public void SaveCommit()
        {
            _context.SaveChanges();
        }
    }
}
