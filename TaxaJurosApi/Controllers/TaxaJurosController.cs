using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaxaJurosApi.Interfaces;

namespace TaxaJurosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJuros _taxaJuros;
        public TaxaJurosController(ITaxaJuros taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }
        /// <summary>
        /// Retorna a taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> RetornaTaxaDeJuros()
        {
            var taxa = _taxaJuros.BuscaTaxaJuros();
            return Ok(taxa);
        }
    }
}
