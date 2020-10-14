using NC.Domain.Entities.UsuarioAbordagem;
using System;
using System.Linq.Expressions;

namespace NC.Domain.Queries.UsuarioAbordagem
{
    public class UsuarioAbordagemQueries
    {
        public static Expression<Func<NcUsuarioAbordagem, bool>> ObterTodos()
        {
            return x => x.Id > 0;
        }
        public static Expression<Func<NcUsuarioAbordagem, bool>> ObterPorId(int id)
        {
            return x => x.Id == id;
        }
    }
}


