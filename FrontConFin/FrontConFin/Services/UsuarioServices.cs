using FrontConFin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrontConFin.Services
{
    public class UsuarioServices
    {
        public async static Task<UsuarioResponse> Login(UsuarioLogin login)
        {
            UsuarioResponse usuarioResponse = null;

            var endpoint = Program.Configuration.GetSection("WFConfin:Endpoint").Value;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(endpoint); //Endereço base de onde será utiliziado a API
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("Usuario/Login", login);

            if (response.IsSuccessStatusCode)
            {
                usuarioResponse = 
                    JsonConvert.DeserializeObject<UsuarioResponse>(await response.Content.ReadAsStringAsync());
            }

            return usuarioResponse;
        }
    }
}
