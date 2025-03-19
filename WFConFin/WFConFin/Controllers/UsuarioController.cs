using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System;
using WFConFin.Data;
using WFConFin.Models;
using WFConFin.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Esse daqui diz que para cada método da Controller, o usuário precisa estar autenticado para acessar
    public class UsuarioController : Controller
    {
        private readonly WFConFinDbContext _context;
        private readonly TokenService _service;

        public UsuarioController(WFConFinDbContext context, TokenService service = null)
        {
            _context = context;
            _service = service;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous] // Deixa que uma pessoa não esteja autenticado para acessar
        public async Task<IActionResult> Login([FromBody] UsuarioLogin usuarioLogin)
        {
            var usuario = _context.Usuario.Where(x => x.Login == usuarioLogin.Login).FirstOrDefault();
            if (usuario == null)
            {
                return NotFound("Usuário inválido.");
            }

            if (usuario.Password != usuarioLogin.Password)
            {
                return BadRequest("Senha inválida");
            }

            var token = _service.GerarToken(usuario);

            usuario.Password = "";

            var result = new UsuarioResponse()
            {
                Usuario = usuario,
                Token = token
            };

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuario()
        {
            try
            {
                var result = _context.Usuario.ToList();
                return Ok(result);

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na listagem de usuários. Exceção {e.Message}");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Gerente,Empregado")] // Configurando quem pode acessar
        public async Task<IActionResult> PostUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var listUsuario = _context.Usuario.Where(x => x.Login == usuario.Login).ToList();

                if (listUsuario.Count > 0)
                {
                    return BadRequest("Erro, informação login inválido");
                }

                await _context.Usuario.AddAsync(usuario);
                var valor = await _context.SaveChangesAsync();

                if (valor == 1)
                {
                    return Ok("Sucesso, usuário incluído");
                }
                else
                {
                    return BadRequest("Erro, usuário não incluído");
                }

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na inclusão de usuário. Exceção {e.Message}");
            }
        }

        [HttpPut]
        [Authorize(Roles = "Gerente,Empregado")]
        public async Task<IActionResult> PutUsuario([FromBody] Usuario usuario)
        {
            try
            {
                _context.Usuario.Update(usuario);
                var valor = await _context.SaveChangesAsync();

                if (valor == 1)
                {
                    return Ok("Sucesso, usuário alterado");
                }
                else
                {
                    return BadRequest("Erro, usuário não alterado");
                }

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na alteração de usuário. Exceção {e.Message}");
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Gerente")]
        public async Task<IActionResult> DeleteUsuario([FromRoute] Guid id)
        {
            try
            {
                Usuario usuario = await _context.Usuario.FindAsync(id);

                if (usuario != null)
                {
                    _context.Usuario.Remove(usuario);
                    var valor = await _context.SaveChangesAsync();
                    if (valor == 1)
                    {
                        return Ok("Sucesso, usuário excluído");
                    }
                    else
                    {
                        return BadRequest("Erro, usuário não excluído");
                    }
                }
                else
                {
                    return NotFound("Erro, usuário não existe.");
                }

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na alteração de usuário. Exceção {e.Message}");
            }
        }

        public override bool Equals(object obj)
        {
            return obj is UsuarioController controller &&
                   EqualityComparer<TokenService>.Default.Equals(_service, controller._service);
        }
    }
}
