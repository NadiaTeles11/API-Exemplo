using Flunt.Notifications;
using Flunt.Validations;
using NC.Domain.Entities.UsuarioAbordagem;
using System;
using NC.Shared.Commands;

namespace NC.Domain.Commands.PessoaExterna
{
    public class AlterarPessoaExternaCommand : Notifiable, ICommand
    {
        //Conceito de CQRS = Segregação por comandos e queries
        //Command como input: escrita, Query como leitura
        //Basicamente é dividir a escrita da leitura
        //Os Commands são responsavis pelo transporte entre uma camada e outra que é em JSON

        #region Contrutores

        // construtor sem parametros foi criado devido a criação do outro,  porem ele sozinho nunca deve ser criado para que nada de fora altere o que está aqui dentro
        public AlterarPessoaExternaCommand() { }

        public AlterarPessoaExternaCommand(int id, byte[] imagem, string nome, string grupo, string telefoneFixo, string telefoneMovel, string email, string observacao, string pessoaDocTipo, string documentoNumero, DateTime? nascimento, int? empresaId, string empresaNome, string complemento1, string complemento2, string complemento3, string complemento4, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, DateTime? contratacaoInicio, DateTime? contratacaoFim, DateTime? integracaoInicio, DateTime? integracaoFim, DateTime? segurancaInicio, DateTime? segurancaFim, DateTime? exameMedicoInicio, DateTime? exameMedicoFim, bool? ignorarBiometria, DateTime? ultimaVisitaDataHora, int ultimoVisitadoId, string ultimoMotivo, bool? exPessoaInterna, DateTime? dataCadastro, byte origemCadastro, bool? presente, NcUsuarioAbordagem? abordagem, bool? status)
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
            UltimoVisitadoId = UltimoVisitadoId;
            UltimoMotivo = ultimoMotivo;
            ExPessoaInterna = exPessoaInterna;
            DataCadastro = dataCadastro;
            OrigemCadastro = origemCadastro;
            Presente = presente;
            Abordagem = abordagem;
            Status = status;
        }



        // construtor com parametros facilita os testes, porem não obrigatorio


        #endregion

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
        public NcUsuarioAbordagem? Abordagem { get; set; }
        public bool? Status { get; set; }

        #endregion

        #region Validações
        public void Validate()
        {

            AddNotifications(new Contract()
              .Requires()
              .HasMinLen(Nome, 3, "Nome", "Nome deve conter pelo menos 3 caracteres")
              .HasMaxLen(Nome, 50, "Nome", "Nome deve conter até 50 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Grupo, 20, "Grupo", "Grupo deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(TelefoneFixo, 15, "TelefoneFixo", "Telefone Fixo deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(TelefoneMovel, 15, "TelefoneMovel", "TelefoneMovel deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Email, 50, "Email", "Email deve conter até 50 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Observacao, 100, "Observacao", "Observacao deve conter até 100 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(PessoaDocTipo, 4, "PessoaDocTipo", "Pessoa Doc Tipo deve conter até 4 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(DocumentoNumero, 15, "DocumentoNumero", "Documento Numero Doc Tipo deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EmpresaNome, 30, "EmpresaNome", "EmpresaNome deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento1, 30, "Complemento1", "Complemento1 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento2, 30, "Complemento2", "Complemento2 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento3, 30, "Complemento3", "Complemento3 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento4, 30, "Complemento4", "Complemento4 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoLogradouro, 30, "Logradouro", "EnderecoLogradouro deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoNumero, 6, "Numero", "Numero deve conter até 6 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoComplemento, 10, "Complemento", "Complemento deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoBairro, 20, "Bairro", "Bairro deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoCep, 9, "Cep", "Cep deve conter até 9 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoCidade, 20, "Cidade", "Cidade deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoEstado, 20, "Estado", "Estado deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoPais, 20, "Pais", "Pais deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(UltimoMotivo, 30, "UltimoMotivo", "Ultimo Motivo deve conter até 30 caracteres")
              .IsBetween(OrigemCadastro, 0, 3, "OrigemCadastro", "OrigemCadastro deve estar entre 0 e 3")
              //.IsBetween(Abordagem, 0, 4, "Abordagem", "Abordagem deve estar entre 0 e 4")
              //.IsGreaterOrEqualsThan(ContratacaoInicio, DateTime.UtcNow, "ContratacaoInicio", "Contratacao Inicio deve ser maior ou igual a hoje")


              //IsGreaterThan(DateTime val, DateTime comparer, string property, string message)


              );
        }

        #endregion 
    }
}