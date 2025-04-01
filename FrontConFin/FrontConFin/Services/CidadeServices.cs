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
    public class CidadeServices
    {

        public async static Task<List<Cidade>> GetCidade()
        {
            List<Cidade> lista = new List<Cidade>();
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync("Cidade");

                if (response.IsSuccessStatusCode)
                {
                    lista = JsonConvert.DeserializeObject<List<Cidade>>(await response.Content.ReadAsStringAsync());
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

        public async static Task<List<Cidade>> Pesquisa(string valor)
        {
            List<Cidade> lista = new List<Cidade>();
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync($"Cidade/Pesquisa?valor={valor}");

                if (response.IsSuccessStatusCode)
                {
                    lista = JsonConvert.DeserializeObject<List<Cidade>>(await response.Content.ReadAsStringAsync());
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

        public async static Task<PaginacaoResponse<Cidade>> Paginacao(string valor, int skip, int take, bool ordemDesc)
        {
            PaginacaoResponse<Cidade> paginacao = new PaginacaoResponse<Cidade>(new List<Cidade>(),0,1,10);
            try
            {
                var endpoint = Program.Configuration.GetSection("WFConFin:Endpoint").Value;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                HttpResponseMessage response = await client.GetAsync($"Cidade/Paginacao?valor={valor}&skip={skip}&take={take}&ordemDesc={ordemDesc}");

                if (response.IsSuccessStatusCode)
                {
                    paginacao = JsonConvert.DeserializeObject<PaginacaoResponse<Cidade>>(await response.Content.ReadAsStringAsync());
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

        public async static Task<bool> PostCidade(Cidade cidade)
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
                var json = JsonConvert.SerializeObject(cidade);
                var contentCidade = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("Cidade", contentCidade);

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

        public async static Task<bool> PutCidade(Cidade cidade)
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
                var json = JsonConvert.SerializeObject(cidade);
                var contentCidade = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync("Cidade", contentCidade);

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

        public async static Task<bool> DeleteCidade(string id)
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

                HttpResponseMessage response = await client.DeleteAsync($"Cidade/{id}");

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
