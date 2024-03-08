using System;

using Microsoft.AspNetCore.Mvc;

using Models;
using Models.Interfaces;

using Services.Services;

namespace WebAPI.Controllers
{

    /// <summary>
    /// Controller que oferece a API para c�lculo do CDB segundo valor e per�odo.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CdbController : Controller
    {

        private readonly ICalculoCdbService _Service;

        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="pService">Servi�o principal, valor alimentado pelos factories</param>
        public CdbController(ICalculoCdbService pService)
        {
            _Service = pService;
        }

        /// <summary>
        /// M�todo que calcular� os redimento segundo o valor e o per�odo informado.
        /// </summary>
        /// <param name="pPars"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <response code="200">C�culo resolvido com os valores informados.</response>
        /// <response code="400">Par�metros da requisi��o est�o incorretos.</response>
        /// <response code="500">Erro interno no Servidor.</response>        
        [HttpPost("Calcular")]
        public IActionResult Calcular([FromBody] CdbEntrada pPars)
        {
            if (pPars == null)
                return BadRequest(CalculoCdbService.PARAM_NULL);
            if (pPars.Valor <= 0)
                return BadRequest(CalculoCdbService.VALOR_INVALIDO);
            if (pPars.Meses <= 1)
               return BadRequest(CalculoCdbService.MESES_INVALIDO);

            return Ok(_Service.Calcular(pPars));
        }
    }
}
