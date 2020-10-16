using HotChocolate.Types;
using NC.Domain.Entities;

namespace NC.Api.GraphQL.Types
{
    public class PessoaExternaType : ObjectType<NcPessoaExterna>
    {
        protected override void Configure(IObjectTypeDescriptor<NcPessoaExterna> descriptor)
        {
            descriptor.Field(b => b.Id).Type<IntType>().Description("Identificação do registro");          
            descriptor.Field(b => b.Nome).Type<StringType>().Description("Nome da pessoa");
            descriptor.Field(b => b.Grupo).Type<StringType>().Description("Nome do grupo da pessoa");
            descriptor.Field(b => b.TelefoneFixo).Type<StringType>().Description("Número do telefone comercial para contato");
           
        }
    }
}



