using System;

namespace NC.Api.GraphQL.Mutations.PessoaExterna
{
    public class UsuarioPessoaExternaInserirInput
    {
        //public UsuarioPessoaExternaInserirInput() { }
        public UsuarioPessoaExternaInserirInput(byte[]? imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, bool? status)
        {           
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;          
        }

        #region propriedades

        public string Nome { get; set; }
        public string Grupo { get; set; }
        public string TelefoneFixo { get; set; }      

        #endregion
    }

    public class UsuarioPessoaExternaAlterarInput
    {
        //public UsuarioPessoaExternaAlterarInput() { }
        public UsuarioPessoaExternaAlterarInput(int id, byte[]? imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, bool? status)
        {
            Id = id;         
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;
            
        }

        #region propriedades
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Grupo { get; set; }
        public string TelefoneFixo { get; set; }      

        #endregion propriedades
    }

}
