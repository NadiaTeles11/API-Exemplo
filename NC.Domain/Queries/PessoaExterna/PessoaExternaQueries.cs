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
        public static Expression<Func<NcPessoaExterna, bool>> ObterAtivos()
        {
            return x => x.Status == true;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterInativos()
        {
            return x => x.Status == false;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterPorEmail(string email)
        {
            return x => x.Email == email;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterPorDocumento(string documentoNumero)
        {
            return x => x.DocumentoNumero == documentoNumero;
        }
        public static Expression<Func<NcPessoaExterna, bool>> ObterPorPeriodo(string document, DateTime date, bool active)
        {
            return x =>
                x.DocumentoNumero == document &&
                x.Status == true &&
                x.DataCadastro == date.Date;
        }
    }
}
