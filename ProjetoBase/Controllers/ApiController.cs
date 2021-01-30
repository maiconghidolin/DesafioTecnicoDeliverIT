using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoBase.Controllers
{

    [Route("[controller]")]
    public class ApiController : ControllerBase
    {

        public RetornoPadraoControllers Json(Exception exception)
        {
            RetornoPadraoControllers retorno = new RetornoPadraoControllers
            {
                Sucesso = false,
                Dados = null,
                MensagemErro = exception.InnerException != null ? (exception.InnerException.Message != "" ? exception.InnerException.Message: exception.Message) : exception.Message
            };

            return retorno;
        }

        public RetornoPadraoControllers Json(bool sucesso, object dados = null, string erro = "")
        {
            RetornoPadraoControllers retorno = new RetornoPadraoControllers
            {
                Sucesso = sucesso,
                Dados = dados,
                MensagemErro = erro
            };

            return retorno;
        }

    }

    public class RetornoPadraoControllers
    {
        public bool Sucesso { get; set; }
        public string MensagemErro { get; set; }
        public object Dados { get; set; }
    }

}