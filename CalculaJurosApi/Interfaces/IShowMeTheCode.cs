using Microsoft.Extensions.Configuration;

namespace CalculaJurosApi.Interfaces
{
    public interface IShowMeTheCode
    {
        string RetornaUrl(IConfiguration config);
    }
}
