using TaxaJurosApi.Interfaces;

namespace TaxaJurosApi.Models
{
    public class TaxaJuros : ITaxaJuros
    {
        private readonly double _taxa = 0.01;

        public double BuscaTaxaJuros() => _taxa;
    }
}
