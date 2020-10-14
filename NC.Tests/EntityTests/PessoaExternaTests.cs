using Microsoft.VisualStudio.TestTools.UnitTesting;
using NC.Domain.Entities;

namespace NC.Tests.EntityTests
{
    [TestClass]
    public class PessoaExternaTests
    {
        private readonly NcPessoaExterna _validPessoaExterna = new NcPessoaExterna();

        [TestMethod]
        public void Dado_uma_nova_pessoa_a_mesma_nao_pode_ser_concluida()
        {
            Assert.AreEqual(_validPessoaExterna.Status, false)
;        }
    }
}
