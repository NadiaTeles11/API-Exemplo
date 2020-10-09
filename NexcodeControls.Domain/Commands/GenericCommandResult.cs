using Newtonsoft.Json;
using NexcodeControls.Shared.Commands;

namespace NexcodeControls.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        //Todos os retornos que sairem dos Handles serão do tipo GenericCommandResult


        public GenericCommandResult() { }

        public GenericCommandResult(bool sucesso, string mensagem, MensagemTipo mensagemtipo, object dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            MensagemTipo = mensagemtipo;
            Objeto = JsonConvert.SerializeObject(dados);
        }

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }

        public MensagemTipo MensagemTipo { get; set; }

        public string Objeto { get; set; }

    }
}
