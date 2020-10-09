namespace NexcodeControls.Domain.Entities.UsuarioAbordagem
{
    public partial class NcUsuarioAbordagem : BaseEntity
    {

        #region Propriedades privadas
        private string _mensagem;
        #endregion

        #region Construtores
       

        public NcUsuarioAbordagem()
        {

        }

        public NcUsuarioAbordagem(byte? tipo, string mensagem)
        {
            Tipo = tipo;
            Mensagem = mensagem;
        }


        #endregion

        #region Propriedades
        public byte? Tipo { get; private set; }
        public string Mensagem { get => _mensagem; private set => _mensagem = value.ToUpper(); }

        //public NcPessoaInterna PessoaInterna { get; private set; }
        #endregion

        #region Metodos
        public void Alterar(byte? tipo, string mensagem)
        {
            Tipo = tipo;
            Mensagem = mensagem;
        }

        #endregion
    }
}
