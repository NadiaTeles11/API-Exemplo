using Microsoft.VisualStudio.TestTools.UnitTesting;
using NC.Domain.Commands;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Handlers;
using NC.Tests.Repositories;

namespace NC.Tests.HandlerTests
{
    [TestClass]
    public class CreatePessoaExternaHandlerTests
    {

        private readonly InserirPessoaExternaCommand _invalidCommand = new InserirPessoaExternaCommand();
        private readonly InserirPessoaExternaCommand _validCommand = new InserirPessoaExternaCommand();
        private readonly PessoaExternaHandler _handler = new PessoaExternaHandler(new FakePessoaExternaRepository());
        private GenericCommandResult _result = new GenericCommandResult();
        public CreatePessoaExternaHandlerTests()
        {
            _invalidCommand.Nome = "";   
            _validCommand.Nome = "NADIA TELES";
        }

        [TestMethod]
        public void Dado_um_Comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle( _invalidCommand);
            Assert.AreEqual(_result.Sucesso, false);
        }

        [TestMethod]
        public void Dado_um_Comando_valido_deve_criar_a_pessoaexterna()
        {
            _result = (GenericCommandResult)_handler.Handle( _validCommand);
            Assert.AreEqual(_result.Sucesso, true);
        }
    }
}
