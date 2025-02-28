using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WFConFin.Data;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : Controller
    {

        private readonly WFConFinDbContext _context;

        public CidadeController(WFConFinDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCidades()
        {
            try
            {
                var result = _context.Cidade.ToList();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro na listagem de cidades. Exceção: {e.Message}");
            }
        }

        [HttpPost]
        public IActionResult PostCidades([FromBody] Cidade cidade)
        {
            try
            {
                _context.Cidade.Add(cidade);
                var valor = _context.SaveChanges();

                if (valor == 1)
                {
                    return Ok("Sucesso, cidade incluída.");
                }
                else
                {
                    return BadRequest("Erro, cidade não incluída.");
                }

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na inclusão de cidade. Exceção: {e.Message}");
            }
        }

        [HttpPut]
        public IActionResult PutCidades([FromBody] Cidade cidade)
        {
            try
            {
                _context.Cidade.Update(cidade);
                var valor = _context.SaveChanges();

                if (valor == 1)
                {
                    return Ok("Sucesso, cidade alterada.");
                }
                else
                {
                    return BadRequest("Erro, cidade não alterada.");
                }

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na alteração de cidade. Exceção: {e.Message}");
            }
        }
    }
}
