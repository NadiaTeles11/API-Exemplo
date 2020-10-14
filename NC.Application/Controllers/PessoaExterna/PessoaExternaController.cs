using Microsoft.AspNetCore.Mvc;
using NC.Domain.Commands;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Entities;
using NC.Domain.Handlers;
using NC.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NC.Api.Controllers
{
    [Route("v1/pessoaexterna")]
    [ApiController]
    public class PessoaExternaController : ControllerBase
    {

        [Route("")]
        [HttpGet]
        public IEnumerable<NcPessoaExterna> GetAll(
            [FromServices] IPessoaExternaRepository repository)
        {
            //command.sessao = User.Claims.FirstOrDefault(X500DistinguishedName => X500DistinguishedName.Type == "user_id")?.Value;
            return repository.ObterTodos();
        }


        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
           // [FromBody] Sessao sessao,
            [FromBody] InserirPessoaExternaCommand command,
            [FromServices] PessoaExternaHandler handler)
        {
            //command.sessao = User.Claims.FirstOrDefault(X500DistinguishedName => X500DistinguishedName.Type == "user_id")?.Value;
            return (GenericCommandResult)handler.Handle(command);
        }


        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
            //[FromBody] Sessao sessao,
            [FromBody] AlterarPessoaExternaCommand command,
            [FromServices] PessoaExternaHandler handler)
        {
            //command.sessao = User.Claims.FirstOrDefault(X500DistinguishedName => X500DistinguishedName.Type == "user_id")?.Value;
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpDelete]
        public GenericCommandResult Delete(
            //[FromBody] Sessao sessao,
            [FromBody] ExcluirPessoaExternaCommand command,
            [FromServices] PessoaExternaHandler handler)
        {
            //command.sessao = User.Claims.FirstOrDefault(X500DistinguishedName => X500DistinguishedName.Type == "user_id")?.Value;
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}