using FIAP.Global_ImpactWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Repositories
{
    public interface IDoacaoRepository
    {
        void Cadastrar(Doacao doacao);

        IList<Doacao> Listar();
        void SaveCommit();

        int Contar();
    }
}
