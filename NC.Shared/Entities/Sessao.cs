namespace NC.Shared.Entities
{
    public class Sessao
    {
        public Sessao(string token, string softwareLicenca, string solucaoEspecifica, string solucaoIntegrada, string aplicativo, string aplicativoVersao)
        {
            Token = token;
            SoftwareLicenca = softwareLicenca;
            SolucaoEspecifica = solucaoEspecifica;
            SolucaoIntegrada = solucaoIntegrada;
            Aplicativo = aplicativo;
            AplicativoVersao = aplicativoVersao;
        }
        public string Token { get; set; }

        public string SoftwareLicenca { get; set; }

        public string SolucaoEspecifica { get; set; }

        public string SolucaoIntegrada { get; set; }

        public string Aplicativo { get; set; }

        public string AplicativoVersao { get; set; }
    }
}
