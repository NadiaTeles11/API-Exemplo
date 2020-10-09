using HotChocolate.Types;
using HotChocolate.Types.Relay;
using NexcodeControls.Api.GraphQL.Types;
using NexcodeControls.Domain.Entities;
using NexcodeControls.Domain.Repositories;
using System.Linq;

namespace NexcodeControls.Api.GraphQL.Query
{
    [ExtendObjectType(Name = "Query")]
    public class PessoaExternaQuery
    {
        private readonly IPessoaExternaRepository _repository;
        public PessoaExternaQuery(IPessoaExternaRepository repository)
        {
            _repository = repository;
        }

        [UsePaging(SchemaType = typeof(PessoaExternaType))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<NcPessoaExterna> UsuarioPessoaExterna(Sessao sessao)
        {
            try
            {
                return _repository.ObterTodos().AsQueryable();

                //var query = await _repository.ObterTodos();
                //return query.AsQueryable();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
