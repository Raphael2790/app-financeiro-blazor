using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts;
using AgioBank.Tests.UseCases.Authenticate.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgioBank.Tests.UseCases.Authenticate
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
        public async Task Dado_um_login_invalido_a_resposta_deve_ser_Unauthorized()
        {
            var emailInvalido = "eduardo.boca@gmail.com";
            var senhaInvalida = "1234";

            _request = new(emailInvalido, senhaInvalida);
            var response = await _handler.Handle(_request, new CancellationToken());

            Assert.AreEqual(response.Status, System.Net.HttpStatusCode.Unauthorized);
        }

        [TestMethod]
        public async Task Dado_um_login_valido_a_resposta_deve_conter_o_token()
        {
            var emailValido = "eduardo.boca@gmail.com";
            var senhaValida = "123456"; 
            
            _request = new(emailValido, senhaValida);

            var response = await _handler.Handle(_request, new CancellationToken());
            Assert.IsNotNull(response.Data!.Token);
        }

    }
}
