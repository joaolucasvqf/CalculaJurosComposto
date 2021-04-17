using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CalculaJurosApi.Interfaces
{
    public interface ICalculaJuros
    {
        Task<double> CalcularJuros(double valorInicial, double meses, IConfiguration config);
    }
}
