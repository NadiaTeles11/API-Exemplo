using NC.Domain.Entities.Garagem;
using NC.Domain.Entities.Veiculo;
using NexcodeControls.Domain.Entities.UsuarioAbordagem;
using System;
using System.Collections.Generic;

namespace NexcodeControls.Domain.Entities
{
    public partial class NcPessoaExterna : BaseEntity
    {

        #region Propriedades privadas
        private string _nome;
        private string _grupo;
        private string _telefoneFixo;
        private string _telefoneMovel;
        private string _email;
        private string _observacao;
        private string _pessoaDocTipo;
        private string _documentoNumero;
        private string _empresaNome;
        private string _complemento1;
        private string _complemento2;
        private string _complemento3;
        private string _complemento4;
        private string _enderecoLogradouro;
        private string _enderecoNumero;
        private string _enderecoComplemento;
        private string _enderecoBairro;
        private string _enderecoCep;
        private string _enderecoCidade;
        private string _enderecoEstado;
        private string _enderecoPais;
        private string _ultimoMotivo;
        #endregion

        #region Construtores


        public NcPessoaExterna() { }

        public NcPessoaExterna(byte[] imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, NcUsuarioAbordagem? abordagem, bool? status)
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
            Abordagem = abordagem;
            Status = status;
        }



        // construtor com parametros facilita os testes


        #endregion

        #region Propriedades
        public byte[]? Imagem { get; private set; }
        public string Nome { get => _nome; private set => _nome = value.ToUpper(); }
        public string Grupo { get => _grupo; private set => _grupo = value.ToUpper(); }
        public string TelefoneFixo { get => _telefoneFixo; private set => _telefoneFixo = value.ToUpper(); }
        public string TelefoneMovel { get => _telefoneMovel; private set => _telefoneMovel = value.ToUpper(); }
        public string Email { get => _email; private set => _email = value.ToUpper(); }
        public string Observacao { get => _observacao; private set => _observacao = value.ToUpper(); }
        public string PessoaDocTipo { get => _pessoaDocTipo; private set => _pessoaDocTipo = value.ToUpper(); }
        public string DocumentoNumero { get => _documentoNumero; private set => _documentoNumero = value.ToUpper(); }
        public DateTime? Nascimento { get; private set; }
        public int? EmpresaId { get; private set; }
        public NcEmpresa Empresa { get; private set; }

        public string EmpresaNome { get => _empresaNome; private set => _empresaNome = value.ToUpper(); }
        public string Complemento1 { get => _complemento1; private set => _complemento1 = value.ToUpper(); }
        public string Complemento2 { get => _complemento2; private set => _complemento2 = value.ToUpper(); }
        public string Complemento3 { get => _complemento3; private set => _complemento3 = value.ToUpper(); }
        public string Complemento4 { get => _complemento4; private set => _complemento4 = value.ToUpper(); }
        public string EnderecoLogradouro { get => _enderecoLogradouro; private set => _enderecoLogradouro = value.ToUpper(); }
        public string EnderecoNumero { get => _enderecoNumero; private set => _enderecoNumero = value.ToUpper(); }
        public string EnderecoComplemento { get => _enderecoComplemento; private set => _enderecoComplemento = value.ToUpper(); }
        public string EnderecoBairro { get => _enderecoBairro; private set => _enderecoBairro = value.ToUpper(); }
        public string EnderecoCep { get => _enderecoCep; private set => _enderecoCep = value.ToUpper(); }
        public string EnderecoCidade { get => _enderecoCidade; private set => _enderecoCidade = value.ToUpper(); }
        public string EnderecoEstado { get => _enderecoEstado; private set => _enderecoEstado = value.ToUpper(); }
        public string EnderecoPais { get => _enderecoPais; private set => _enderecoPais = value.ToUpper(); }
        public DateTime? ContratacaoInicio { get; private set; }
        public DateTime? ContratacaoFim { get; private set; }
        public DateTime? IntegracaoInicio { get; private set; }
        public DateTime? IntegracaoFim { get; private set; }
        public DateTime? SegurancaInicio { get; private set; }
        public DateTime? SegurancaFim { get; private set; }
        public DateTime? ExameMedicoInicio { get; private set; }
        public DateTime? ExameMedicoFim { get; private set; }
        public bool? IgnorarBiometria { get; private set; }
        public DateTime? UltimaVisitaDataHora { get; private set; }
        public int UltimoVisitadoId { get; private set; }

        //public NcPessoaInterna UltimoVisitado { get; private set; }
        public string UltimoMotivo { get => _ultimoMotivo; private set => _ultimoMotivo = value.ToUpper(); }
        public bool? ExPessoaInterna { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public byte OrigemCadastro { get; private set; }
        public bool? Presente { get; private set; }
        public int AbordagemId { get; private set; }
        public NcUsuarioAbordagem? Abordagem { get; private set; }
        public bool? Status { get; private set; }

        //public ICollection<NcVeiculo> Veiculos { get; set; } =
        //  new List<NcVeiculo>();

        //public ICollection<NcVagaGaragem> Vagas { get; set; } =
        //new List<NcVagaGaragem>();


        #endregion

        #region Metodos

        public void Alterar(byte[] imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, NcUsuarioAbordagem? abordagem, bool? status)
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
            Abordagem = abordagem;
            Status = status;
        }

        public void AtribuirUltimaVisita()
        {
            UltimaVisitaDataHora = DateTime.Now;
        }

        public void AtribuirUltimoMotivo(string motivo)
        {
            UltimoMotivo = motivo;
        }

        public void AtribuirPresenca()
        {
            Presente = true;
        }

        public void Ativar()
        {
            Status = true;
        }

        public void Inativar()
        {
            Status = false;
        }

        #endregion
    }
}
