using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexcodeControls.Domain.Commands.PessoaExterna;

namespace NexcodeControls.Tests.CommandTests
{
    [TestClass]
    public class CreatePessoaExternaCommandsTests
    {
        //Red Green, Refactor

        private readonly InserirPessoaExternaCommand _invalidCommand = new InserirPessoaExternaCommand();
        private readonly InserirPessoaExternaCommand _validCommand = new InserirPessoaExternaCommand();

        public CreatePessoaExternaCommandsTests()
        {
            _invalidCommand.Nome = "";
            _invalidCommand.Validate();

            _validCommand.Nome = "NADIA TELES";
            _validCommand.Validate();

        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {          
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
