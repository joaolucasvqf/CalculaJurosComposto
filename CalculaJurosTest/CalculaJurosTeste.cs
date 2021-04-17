using CalculaJurosApi.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJurosTest
{
    public class CalculaJurosTeste
    {
        private readonly IConfiguration _config;
        public CalculaJurosTeste()
        {
            var config = new Dictionary<string, string>
            {
                { "Urls:UrlTaxaJuros", "http://localhost:5001/api/TaxaJuros" }
            };
            _config = new ConfigurationBuilder()
                .AddInMemoryCollection(config)
                .Build();
        }
        [Theory]
        [InlineData(100.00, 5, 105.10)]
        public async Task CalculoJuros_igual_ao_esperado(double valorInicial, int meses, double resultadoEsperado)
        {
            CalculaJuros calculaJuros = new CalculaJuros();
            double result = await calculaJuros.CalcularJuros(valorInicial, meses, _config);
            Assert.Equal(resultadoEsperado, result, 2);
        }
    }
}
