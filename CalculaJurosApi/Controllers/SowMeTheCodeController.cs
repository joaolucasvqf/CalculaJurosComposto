using System;
using System.Threading.Tasks;
using CalculaJurosApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CalculaJurosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SowMeTheCodeController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IShowMeTheCode _showMeTheCode;
        public SowMeTheCodeController(IConfiguration config, IShowMeTheCode showMeTheCode)
        {
            _config = config;
            _showMeTheCode = showMeTheCode;
        }
        /// <summary>
        /// Retorna a URL do GitHub com o código desenvolvido
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> SowMeTheCode()
        {
            return Ok();
        }
    }
}
