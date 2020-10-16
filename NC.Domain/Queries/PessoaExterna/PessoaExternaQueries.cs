using NC.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace NC.Domain.Queries
{
    public static class PessoaExternaQueries
    {
        public static Expression<Func<NcPessoaExterna, bool>> ObterTodos()
        {
            return x => x.Id > 0;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterPorId(int id)
        {
            return x => x.Id == id;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterPorUnidade(string unidade)
        {
            //return x => x.EntidadeId == id;
            return null;
        }         
     
    }
}
