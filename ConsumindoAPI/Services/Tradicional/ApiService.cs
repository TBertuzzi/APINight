using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ConsumindoAPI.Helpers;
using ConsumindoAPI.Model;
using Newtonsoft.Json;

namespace ConsumindoAPI.Services
{
    public class ApiService : IApiService
    {


        public async Task<List<Pessoa>> GetUsuario()
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync($"{Constantes.ApiBaseUrl}/person").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {

                    return JsonConvert.DeserializeObject<List<Pessoa>>(
                        await new StreamReader(responseStream)
                            .ReadToEndAsync().ConfigureAwait(false));

                }
            }

            return new List<Pessoa>();


        }
    }
}
