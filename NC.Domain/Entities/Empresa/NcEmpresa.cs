using System;

namespace NC.Domain.Entities
{
    public partial class NcEmpresa : BaseEntity
    {

        #region Propriedades privadas
        private string _nome;
        private string _grupo;
        private string _gestor;
        private string _telefone1;
        private string _telefone2;
        private string _email;
        private string _cnpj;
        private string _ie;
        private string _complemento1;
        private string _complemento2;
        private string _enderecoLogradouro;
        private string _enderecoNumero;
        private string _enderecoComplemento;
        private string _enderecoBairro;
        private string _enderecoCep;
        private string _enderecoCidade;
        private string _enderecoEstado;
        private string _enderecoPais;
        private string _observacao;

        #endregion

        #region Construtores
        public NcEmpresa()
        {

        }

        public NcEmpresa(string nome, string grupo, string gestor, string telefone1, string telefone2, string email, string cnpj, string ie, string complemento1, string complemento2, byte classificacao, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, string observacao, DateTime? dataCadastro)
        {
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

        #region Propriedades

        public string Nome { get => _nome; private set => _nome = value.ToUpper(); }
        public string Grupo { get => _grupo; private set => _grupo = value.ToUpper(); }
        public string Gestor { get => _gestor; private set => _gestor = value.ToUpper(); }
        public string Telefone1 { get => _telefone1; private set => _telefone1 = value.ToUpper(); }
        public string Telefone2 { get => _telefone2; private set => _telefone2 = value.ToUpper(); }
        public string Email { get => _email; private set => _email = value.ToUpper(); }
        public string Cnpj { get => _cnpj; private set => _cnpj = value.ToUpper(); }
        public string Ie { get => _ie; private set => _ie = value.ToUpper(); }
        public string Complemento1 { get => _complemento1; private set => _complemento1 = value.ToUpper(); }
        public string Complemento2 { get => _complemento2; private set => _complemento2 = value.ToUpper(); }
        public byte Classificacao { get; private set; }
        public string EnderecoLogradouro { get => _enderecoLogradouro; private set => _enderecoLogradouro = value.ToUpper(); }
        public string EnderecoNumero { get => _enderecoNumero; private set => _enderecoNumero = value.ToUpper(); }
        public string EnderecoComplemento { get => _enderecoComplemento; private set => _enderecoComplemento = value.ToUpper(); }
        public string EnderecoBairro { get => _enderecoBairro; private set => _enderecoBairro = value.ToUpper(); }
        public string EnderecoCep { get => _enderecoCep; private set => _enderecoCep = value.ToUpper(); }
        public string EnderecoCidade { get => _enderecoCidade; private set => _enderecoCidade = value.ToUpper(); }
        public string EnderecoEstado { get => _enderecoEstado; private set => _enderecoEstado = value.ToUpper(); }
        public string EnderecoPais { get => _enderecoPais; private set => _enderecoPais = value.ToUpper(); }
        public string Observacao { get => _observacao; private set => _observacao = value.ToUpper().ToUpper(); }
        public DateTime? DataCadastro { get; private set; }

        //public ICollection<NcEmpresaSite> EmpresaSite { get; private set; } =
        //     new List<NcEmpresaSite>();
        
        #endregion

        #region Metodos
        public void Alterar(string nome, string grupo, string gestor, string telefone1, string telefone2, string email, string cnpj, string ie, string complemento1, string complemento2, byte classificacao, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, string enderecoCidade, string enderecoEstado, string enderecoPais, string observacao, DateTime? dataCadastro)
        {
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

    }
}
