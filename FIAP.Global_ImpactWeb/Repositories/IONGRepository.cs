using FIAP.Global_ImpactWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Repositories
{
    public interface IONGRepository
    {
        void Cadastro(UserONG ong);

        void Atualizar(UserONG ong);

        void Deletar(int id);

        void SaveCommit();

        IList<UserONG> Listar();

        UserONG BuscaPorId(int id);

        IList<UserONG> BuscarPor(Expression<Func<UserONG, bool>> filtro);
    }
}
