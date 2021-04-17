using CalculaJurosApi.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculaJurosTest
{
    public class ShowMeTheCodeTest
    {
        private readonly IConfiguration _config;
        public ShowMeTheCodeTest()
        {
            var config = new Dictionary<string, string>
            {
                { "Urls:UrlCodigo", "https://github.com/joaolucasvqf/CalculaJurosComposto" }
            };
            _config = new ConfigurationBuilder()
                .AddInMemoryCollection(config)
                .Build();
        }
        [Theory]
        [InlineData("https://github.com/joaolucasvqf/CalculaJurosComposto")]
        public void ShowMeTheCodeTest_igual_ao_esperado(string respostaEsperada)
        {
            ShowMeTheCode showMeTheCode = new ShowMeTheCode();
            var result = showMeTheCode.RetornaUrl(_config);
            Assert.Equal(respostaEsperada, result);
        }
    }
}
