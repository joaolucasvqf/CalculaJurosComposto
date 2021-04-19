using System;
using System.Threading.Tasks;
using CalculaJurosApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CalculaJurosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJusrosController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ICalculaJuros _calculaJuros;
        public CalculaJusrosController(IConfiguration config, ICalculaJuros calculaJuros)
        {
            _config = config;
            _calculaJuros = calculaJuros;
        }

        /// <summary>
        /// Retorna o calculo de juros composto baseado nos dados informados
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet("{valorInicial}/{meses}")]
        public async Task<IActionResult> CalculaJuros(decimal valorInicial, int meses)
        {
            try
            {
                return Ok(await _calculaJuros.CalcularJuros((double)valorInicial, meses, _config));
            }
            catch (Exception ex)
            {
                return UnprocessableEntity("Erro ao realizar o calculo: " + ex.Message);
            }
        }
    }
}
