using FrontConFin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConFin.Services
{
    public class EstadoServices
    {

        public async static Task<List<Estado>> GetEstados()
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync("Estado");

                if (response.IsSuccessStatusCode)
                {
                    lista = JsonConvert.DeserializeObject<List<Estado>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return lista;
        }

        public async static Task<List<Estado>> Pesquisa(string valor)
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync($"Estado/Pesquisa?valor={valor}");

                if (response.IsSuccessStatusCode)
                {
                    lista = JsonConvert.DeserializeObject<List<Estado>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return lista;
        }

        public async static Task<PaginacaoResponse<Estado>> Paginacao(string valor, int skip, int take, bool ordemDesc)
        {
            PaginacaoResponse<Estado> paginacao = new PaginacaoResponse<Estado>(new List<Estado>(),0,1,10);
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync($"Estado/Paginacao?valor={valor}&skip={skip}&take={take}&ordemDesc={ordemDesc}");

                if (response.IsSuccessStatusCode)
                {
                    paginacao = JsonConvert.DeserializeObject<PaginacaoResponse<Estado>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return paginacao;
        }

        public async static Task<bool> PostEstado(Estado estado)
        {
            bool resultado = false;
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                var json = JsonConvert.SerializeObject(estado);
                var contentEstado = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("Estado", contentEstado);

                if (response.IsSuccessStatusCode)
                {
                    resultado = true;
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return resultado;
        }

        public async static Task<bool> PutEstado(Estado estado)
        {
            bool resultado = false;
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                var json = JsonConvert.SerializeObject(estado);
                var contentEstado = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync("Estado", contentEstado);

                if (response.IsSuccessStatusCode)
                {
                    resultado = true;
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return resultado;
        }

        public async static Task<bool> DeleteEstado(string sigla)
        {
            bool resultado = false;
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);

                HttpResponseMessage response = await client.DeleteAsync($"Estado/{sigla}");

                if (response.IsSuccessStatusCode)
                {
                    resultado = true;
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }

            return resultado;
        }


    }
}
