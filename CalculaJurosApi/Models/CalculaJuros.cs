using CalculaJurosApi.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace CalculaJurosApi.Models
{
    public class CalculaJuros : ICalculaJuros
    {
        public async Task<double> CalcularJuros(double valorInicial, double meses, IConfiguration config)
        {
            var taxaJuros = await ObterTaxaJuros(config);
            var valorFinal = valorInicial * Math.Pow((1 + taxaJuros), meses);
            return TrucanResultado(valorFinal);
        }

        private async Task<double> ObterTaxaJuros(IConfiguration config)
        {
            HttpClient httpClient = new HttpClient();
            Uri urlRequisicao = new Uri(config.GetSection("Urls").GetSection("UrlTaxaJuros").Value);
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(urlRequisicao);
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<double>(response);
            }

            return 0;
        }

        private double TrucanResultado(double valor) => Math.Truncate(100 * valor) / 100;
    }
}
