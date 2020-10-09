using NexcodeControls.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace NexcodeControls.Domain.Queries.Entidade
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
