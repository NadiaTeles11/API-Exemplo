using NexcodeControls.Domain.Entities;
using NexcodeControls.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NexcodeControls.Tests.Repositories
{
    public class FakePessoaExternaRepository : IPessoaExternaRepository
    {
        public NcPessoaExterna Alterar(NcPessoaExterna item)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(NcPessoaExterna item)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna Inserir(NcPessoaExterna item)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorDocumento(string documentoNumero)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorDocumentoTipo(string documentoNumero, string tipo)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterPorPeriodo(string documentoNumero, DateTime data, bool ativo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterPorUnidade(string unidade)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NcPessoaExterna> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterTodosInativos()
        {
            throw new NotImplementedException();
        }
    }
}
