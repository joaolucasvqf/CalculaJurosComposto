using System;
using TaxaJurosApi.Interfaces;
using TaxaJurosApi.Models;
using Xunit;

namespace TaxaJurosTest
{
    public class TaxaJurosTest
    {
        [Theory]
        [InlineData(0.01)]
        public void TaxaJuros_igual_ao_espeado(double valorTaxaJuros)
        {
            TaxaJuros taxaJuros = new TaxaJuros();
            var resultTaxaJuros = taxaJuros.BuscaTaxaJuros();
            Assert.Equal(valorTaxaJuros, resultTaxaJuros);
        }
    }
}
