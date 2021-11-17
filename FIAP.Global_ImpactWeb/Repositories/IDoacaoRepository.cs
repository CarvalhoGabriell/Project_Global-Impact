using FIAP.Global_ImpactWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Repositories
{
    public interface IDoacaoRepository
    {
        void Cadastrar(Doacao doacao);

        IList<Doacao> Listar();

        IList<Doacao> BuscarPor(Expression<Func<Doacao, bool>>filtro);

        void SaveCommit();

        int Contar(Expression<Func<Doacao, bool>> filtro);
    }
}
