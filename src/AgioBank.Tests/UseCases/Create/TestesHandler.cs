using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Create;
using AgioBank.Contexts.AccountContext.UseCases.Create.Contracts;
using AgioBank.Tests.UseCases.Create.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgioBank.Tests.UseCases.Create
{
    [TestClass]
    public class TestesHandler
    {
        private readonly Handler _handler;
        private readonly Servico _servico;
        private readonly ClienteFake _cliente = new();
        private Request? _request;
        public TestesHandler()
        {
            _servico = new Servico(_cliente);
            _handler = new Handler(_servico);
        }

        [TestMethod]
        public async Task Dada_uma_conta_invalida_a_resposta_deve_ser_BadRequest()
        {
            var emailInvalido = "eduardo.boca";
            _request = new(
                    "João", 
                    "Silva", 
                    "81999999999", 
                    emailInvalido, 
                    "123456", 
                    "Maria", 
                    "123456", 
                    "arquivo.pdf", 
                    null);
            var response = await _handler.Handle(_request, new CancellationToken());

            Assert.AreEqual(response.Status, System.Net.HttpStatusCode.BadRequest);
        }
    }
}
