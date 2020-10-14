
using Microsoft.AspNetCore.Mvc;
using NC.Domain.Entities.UsuarioAbordagem;
using System;

namespace NC.Api.GraphQL.Mutations.PessoaExterna
{
    public class UsuarioPessoaExternaInserirInput
    {
        //public UsuarioPessoaExternaInserirInput() { }
        public UsuarioPessoaExternaInserirInput(byte[]? imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, bool? status)
        {
            Imagem = imagem;
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;
            TelefoneMovel = telefoneMovel;
            Email = email;
            Observacao = observacao;
            PessoaDocTipo = pessoaDocTipo;
            DocumentoNumero = documentoNumero;
            Nascimento = nascimento;
            EmpresaId = empresaId;
            EmpresaNome = empresaNome;
            Complemento1 = complemento1;
            Complemento2 = complemento2;
            Complemento3 = complemento3;
            Complemento4 = complemento4;
            EnderecoLogradouro = enderecoLogradouro;
            EnderecoNumero = enderecoNumero;
            EnderecoComplemento = enderecoComplemento;
            EnderecoBairro = enderecoBairro;
            EnderecoCep = enderecoCep;
            EnderecoCidade = enderecoCidade;
            EnderecoEstado = enderecoEstado;
            EnderecoPais = enderecoPais;
            ContratacaoInicio = contratacaoInicio;
            ContratacaoFim = contratacaoFim;
            IntegracaoInicio = integracaoInicio;
            IntegracaoFim = integracaoFim;
            SegurancaInicio = segurancaInicio;
            SegurancaFim = segurancaFim;
            ExameMedicoInicio = exameMedicoInicio;
            ExameMedicoFim = exameMedicoFim;
            IgnorarBiometria = ignorarBiometria;
            UltimaVisitaDataHora = ultimaVisitaDataHora;
            UltimoVisitadoId = ultimoVisitadoId;
            UltimoMotivo = ultimoMotivo;
            ExPessoaInterna = exPessoaInterna;
            DataCadastro = dataCadastro;
            OrigemCadastro = origemCadastro;
            Presente = presente;          
            Status = status;
        }

        #region propriedades

        public byte[]? Imagem { get; set; }
        public string Nome { get; set; }
        public string Grupo { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public string PessoaDocTipo { get; set; }
        public string DocumentoNumero { get; set; }
        public DateTime? Nascimento { get; set; }
        public int? EmpresaId { get; set; }
        public string EmpresaNome { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoEstado { get; set; }
        public string EnderecoPais { get; set; }
        public DateTime? ContratacaoInicio { get; set; }
        public DateTime? ContratacaoFim { get; set; }
        public DateTime? IntegracaoInicio { get; set; }
        public DateTime? IntegracaoFim { get; set; }
        public DateTime? SegurancaInicio { get; set; }
        public DateTime? SegurancaFim { get; set; }
        public DateTime? ExameMedicoInicio { get; set; }
        public DateTime? ExameMedicoFim { get; set; }
        public bool? IgnorarBiometria { get; set; }
        public DateTime? UltimaVisitaDataHora { get; set; }
        public int UltimoVisitadoId { get; set; }
        public string UltimoMotivo { get; set; }
        public bool? ExPessoaInterna { get; set; }
        public DateTime? DataCadastro { get; set; }
        public byte OrigemCadastro { get; set; }
        public bool? Presente { get; set; }    
        public bool? Status { get; set; }

        #endregion
    }

    public class UsuarioPessoaExternaAlterarInput
    {
        //public UsuarioPessoaExternaAlterarInput() { }
        public UsuarioPessoaExternaAlterarInput(int id, byte[]? imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, bool? status)
        {
            Id = id;
            Imagem = imagem;
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;
            TelefoneMovel = telefoneMovel;
            Email = email;
            Observacao = observacao;
            PessoaDocTipo = pessoaDocTipo;
            DocumentoNumero = documentoNumero;
            Nascimento = nascimento;
            EmpresaId = empresaId;
            EmpresaNome = empresaNome;
            Complemento1 = complemento1;
            Complemento2 = complemento2;
            Complemento3 = complemento3;
            Complemento4 = complemento4;
            EnderecoLogradouro = enderecoLogradouro;
            EnderecoNumero = enderecoNumero;
            EnderecoComplemento = enderecoComplemento;
            EnderecoBairro = enderecoBairro;
            EnderecoCep = enderecoCep;
            EnderecoCidade = enderecoCidade;
            EnderecoEstado = enderecoEstado;
            EnderecoPais = enderecoPais;
            ContratacaoInicio = contratacaoInicio;
            ContratacaoFim = contratacaoFim;
            IntegracaoInicio = integracaoInicio;
            IntegracaoFim = integracaoFim;
            SegurancaInicio = segurancaInicio;
            SegurancaFim = segurancaFim;
            ExameMedicoInicio = exameMedicoInicio;
            ExameMedicoFim = exameMedicoFim;
            IgnorarBiometria = ignorarBiometria;
            UltimaVisitaDataHora = ultimaVisitaDataHora;
            UltimoVisitadoId = ultimoVisitadoId;
            UltimoMotivo = ultimoMotivo;
            ExPessoaInterna = exPessoaInterna;
            DataCadastro = dataCadastro;
            OrigemCadastro = origemCadastro;
            Presente = presente;
            //Abordagem = abordagem;
            Status = status;
        }

        #region propriedades
        public int Id { get; set; }
        public byte[]? Imagem { get; set; }
        public string Nome { get; set; }
        public string Grupo { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public string PessoaDocTipo { get; set; }
        public string DocumentoNumero { get; set; }
        public DateTime? Nascimento { get; set; }
        public int? EmpresaId { get; set; }
        public string EmpresaNome { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoEstado { get; set; }
        public string EnderecoPais { get; set; }
        public DateTime? ContratacaoInicio { get; set; }
        public DateTime? ContratacaoFim { get; set; }
        public DateTime? IntegracaoInicio { get; set; }
        public DateTime? IntegracaoFim { get; set; }
        public DateTime? SegurancaInicio { get; set; }
        public DateTime? SegurancaFim { get; set; }
        public DateTime? ExameMedicoInicio { get; set; }
        public DateTime? ExameMedicoFim { get; set; }
        public bool? IgnorarBiometria { get; set; }
        public DateTime? UltimaVisitaDataHora { get; set; }
        public int UltimoVisitadoId { get; set; }
        public string UltimoMotivo { get; set; }
        public bool? ExPessoaInterna { get; set; }
        public DateTime? DataCadastro { get; set; }
        public byte OrigemCadastro { get; set; }
        public bool? Presente { get; set; }
        public bool? Status { get; set; }

        #endregion propriedades
    }

}
