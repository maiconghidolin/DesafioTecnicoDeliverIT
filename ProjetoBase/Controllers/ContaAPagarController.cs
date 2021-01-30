using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Domain.Entidades;
using ProjetoBase.Domain.Interfaces;

namespace ProjetoBase.Controllers
{

    public class ContaAPagarController : ApiController
    {

        private readonly App.Servicos.ContaAPagar _servicoContaAPagar;
        
        public ContaAPagarController(IRepository repository)
        {
            _servicoContaAPagar = new App.Servicos.ContaAPagar(repository);
        }

        [HttpGet]
        public RetornoPadraoControllers Get()
        {
            try
            {
                var contasAPagar = _servicoContaAPagar.BuscarContasAPagar();
                return Json(true, contasAPagar);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [HttpPost]
        public RetornoPadraoControllers Post([FromBody] ContaAPagar ContaAPagar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicoContaAPagar.SalvarOuAtualizar(ContaAPagar);
                    return Json(true);
                }
                return Json(true, erro: "Dados inválidos");
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [HttpDelete]
        public RetornoPadraoControllers Delete(int Id)
        {
            try
            {
                _servicoContaAPagar.Excluir(Id);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

    }
}
