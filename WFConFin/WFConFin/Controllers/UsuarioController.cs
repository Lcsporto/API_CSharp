using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System;
using WFConFin.Data;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly WFConFinDbContext _context;

        public UsuarioController(WFConFinDbContext context)
        {
            _context = context;
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
                    return Ok("Sucesso, usuaário incluído");
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

    }
}
