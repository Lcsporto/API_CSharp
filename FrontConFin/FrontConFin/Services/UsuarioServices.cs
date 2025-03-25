using FrontConFin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FrontConFin.Services
{
    public class UsuarioServices
    {
        public static UsuarioResponse Login(UsuarioLogin login)
        {
            UsuarioResponse usuarioResponse = null;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:443/WFConFin/api"); //Endereço base de onde será utiliziado a API

            return usuarioResponse;
        }
    }
}
