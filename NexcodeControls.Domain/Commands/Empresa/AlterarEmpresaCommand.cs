using Flunt.Notifications;
using Flunt.Validations;
using NexcodeControls.Shared.Commands;
using System;
namespace NexcodeControls.Domain.Commands.Entidade
{
    public class AlterarEmpresaCommand : Notifiable, ICommand
    {
        #region Contrutores
        public AlterarEmpresaCommand() { }

        public AlterarEmpresaCommand(int id, string nome, string grupo, string gestor, string telefone1, string telefone2, string email, string cnpj, string ie, string complemento1, string complemento2, byte classificacao, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, string observacao, DateTime? dataCadastro)
        {
            Id = id;
            Nome = nome;
            Grupo = grupo;
            Gestor = gestor;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            Cnpj = cnpj;
            Ie = ie;
            Complemento1 = complemento1;
            Complemento2 = complemento2;
            Classificacao = classificacao;
            EnderecoLogradouro = enderecoLogradouro;
            EnderecoNumero = enderecoNumero;
            EnderecoComplemento = enderecoComplemento;
            EnderecoBairro = enderecoBairro;
            EnderecoCep = enderecoCep;
            EnderecoCidade = enderecoCidade;
            EnderecoEstado = enderecoEstado;
            EnderecoPais = enderecoPais;
            Observacao = observacao;
            DataCadastro = dataCadastro;
        }





        #endregion

        #region propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Grupo { get; set; }
        public string Gestor { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public byte Classificacao { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoEstado { get; set; }
        public string EnderecoPais { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCadastro { get; set; }

        #endregion

        #region Validações
        public void Validate()
        {


            AddNotifications(new Contract()
              .Requires()
              .HasMaxLen(Nome, 30, "Nome", "Nome deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Grupo, 20, "Grupo", "Grupo deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Gestor, 30, "Gestor", "Gestor deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Telefone1, 15, "Telefone1", "Telefone1 deve conter até 15 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Telefone2, 15, "Telefone2", "Telefone2 deve conter até 15 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Email, 50, "Email", "Email deve conter até 50 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Cnpj, 18, "Cnpj", "Cnpj deve conter até 18 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Ie, 9, "Ie", "Ie deve conter até 9 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento1, 30, "Complemento1", "Complemento1 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Complemento2, 30, "Complemento2", "Complemento2 deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoLogradouro, 50, "EnderecoLogradouro", "EnderecoLogradouro deve conter até 50 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoNumero, 6, "Numero", "Numero deve conter até 6 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoComplemento, 10, "EnderecoComplemento", "Complemento deve conter até 10 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoBairro, 20, "Bairro", "Bairro deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoCep, 9, "Cep", "Cep deve conter até 9 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoCidade, 30, "Cidade", "Cidade deve conter até 30 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoEstado, 20, "Estado", "Estado deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(EnderecoPais, 20, "Pais", "Pais deve conter até 20 caracteres")
              .HasMaxLengthIfNotNullOrEmpty(Observacao, 100, "Observacao", "Observação deve conter até 20 caracteres")
              .IsBetween(Classificacao, 0, 5, "Classificacao", "Classificacao deve estar entre 0 e 5")
              //HasMaxLengthIfNotNullOrEmpty


              );
        }

        #endregion 
    }
}



