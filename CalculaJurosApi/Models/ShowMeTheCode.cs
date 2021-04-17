using CalculaJurosApi.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CalculaJurosApi.Models
{
    public class ShowMeTheCode : IShowMeTheCode
    {
        public string RetornaUrl(IConfiguration config)
        {
            return config.GetSection("Urls").GetSection("UrlCodigo").Value;
        }
    }
}
