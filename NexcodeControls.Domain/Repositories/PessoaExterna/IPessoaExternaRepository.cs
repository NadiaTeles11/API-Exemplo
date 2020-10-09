using NexcodeControls.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NexcodeControls.Domain.Repositories
{
    public interface IPessoaExternaRepository //: IRepositoryBase<NcPessoaExterna>
    {
        //Inserir
        NcPessoaExterna Inserir(NcPessoaExterna item);

        //Alterar
        NcPessoaExterna Alterar(NcPessoaExterna item);

        //Excluir
        bool Excluir(NcPessoaExterna item);


        //Get

        IQueryable<NcPessoaExterna> ObterTodos();

        NcPessoaExterna ObterPorId(int id);

        IEnumerable<NcPessoaExterna> ObterPorUnidade(string unidade);
              
        IEnumerable<NcPessoaExterna> ObterTodosAtivos();

        IEnumerable<NcPessoaExterna> ObterTodosInativos();

        NcPessoaExterna ObterPorEmail(string email);

        NcPessoaExterna ObterPorNome(string nome);

        NcPessoaExterna ObterPorDocumento(string documentoNumero);
        NcPessoaExterna ObterPorDocumentoTipo(string documentoNumero, string tipo);

        IEnumerable<NcPessoaExterna> ObterPorPeriodo(string documentoNumero, DateTime data, bool ativo);
               
    }
}
