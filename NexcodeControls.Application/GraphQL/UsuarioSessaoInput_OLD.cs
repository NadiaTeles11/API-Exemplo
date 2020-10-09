namespace NexcodeControls.Api.GraphQL
{
    public class UsuarioSessaoInput_OLD
    {
        public UsuarioSessaoInput_OLD(string token, string softwareLicenca, string solucaoEspecifica, string solucaoIntegrada, string aplicativo, string aplicativoVersao)
        {
            Token = token;
            SoftwareLicenca = softwareLicenca;
            SolucaoEspecifica = solucaoEspecifica;
            SolucaoIntegrada = solucaoIntegrada;
            Aplicativo = aplicativo;
            AplicativoVersao = aplicativoVersao;
        }

        //public UsuarioSessaoInput(int operadorId, string operadorNome, int operadorNivelOperacao, string token, string softwareLicenca, string solucaoEspecifica)
        //{
        //    OperadorId = operadorId;
        //    OperadorNome = operadorNome;
        //    OperadorNivelOperacao = operadorNivelOperacao;
        //    Token = token;
        //    SoftwareLicenca = softwareLicenca;
        //    SolucaoEspecifica = solucaoEspecifica;
        //}

        //public int OperadorId { get; set; }

        //public string OperadorNome { get; set; }

        //public int OperadorNivelOperacao { get; set; }

        //public string Token { get; set; }

        //public string SoftwareLicenca { get; set; }

        //public string SolucaoEspecifica { get; set; }

        public string Token { get; set; }

        public string SoftwareLicenca { get; set; }

        public string SolucaoEspecifica { get; set; }

        public string SolucaoIntegrada { get; set; }

        public string Aplicativo { get; set; }

        public string AplicativoVersao { get; set; }

    }
}
