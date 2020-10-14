using NC.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace NC.Domain.Queries.Entidade
{
    public static class EmpresaQueries
    {
        public static Expression<Func<NcEmpresa, bool>> ObterTodos()
        {
            return x => x.Id > 0;
        }
        public static Expression<Func<NcEmpresa, bool>> ObterPorId(int id)
        {
            return x => x.Id == id;
        }
    }
}
