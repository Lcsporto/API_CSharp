using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Linq.Expressions;
using WFConFin.Data;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoController : Controller
    {
        private readonly WFConFinDbContext _context;

        public EstadoController(WFConFinDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetEstados()
        {
            try
            {
                var result = _context.Estado.ToList();

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro na listagem de estados. Exceção: {e.Message}");
            }

        }

        [HttpPost]
        public IActionResult PostEstado([FromBody] Estado estado)
        {
            try
            {
                _context.Estado.Add(estado);
                var valor = _context.SaveChanges();
                if (valor == 1)
                {
                    return Ok("Sucesso, estado incluído.");
                }
                else
                {
                    return BadRequest("Erro, estado não incluído.");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"Erro, estado não incluído. Exceção: {e.Message}");
            }
        }

        [HttpPut]
        public IActionResult PutEstado([FromBody] Estado estado)
        {
            try
            {
                _context.Estado.Update(estado);
                var valor = _context.SaveChanges();
                if (valor == 1)
                {
                    return Ok("Sucesso, estado alterado.");
                }
                else
                {
                    return BadRequest("Erro, estado não incluído.");
                }
            }
            catch (Exception e)
            {
                return BadRequest($"Erro, estado não alterado. Exceção: {e.Message}");
            }
        }

        [HttpDelete("{sigla}")]
        public IActionResult DeleteEstado([FromRoute] string sigla)
        {
            try
            {
                var estado = _context.Estado.Find(sigla);

                if (estado.Sigla == sigla && !string.IsNullOrEmpty(estado.Sigla))
                {
                    _context.Estado.Remove(estado);
                    var valor = _context.SaveChanges();

                    if (valor == 1)
                    {
                        return Ok("Sucesso, estado excluído.");
                    }
                    else
                    {
                        return BadRequest("Erro, estado não excluído.");
                    }
                }
                else
                {
                    return NotFound("Erro, estado não existe.");
                }


            }
            catch (Exception e)
            {
                return BadRequest($"Erro, estado não alterado. Exceção: {e.Message}");
            }
        }

        [HttpGet("{sigla}")]
        public IActionResult GetEstado([FromRoute] string sigla)
        {
            try
            {
                var estado = _context.Estado.Find(sigla);

                if (estado.Sigla == sigla && !string.IsNullOrEmpty(estado.Sigla))
                {
                    return Ok(estado);
                }
                else
                {
                    return NotFound("Erro, estado não existe.");
                }


            }
            catch (Exception e)
            {
                return BadRequest($"Erro, consulta de estado. Exceção: {e.Message}");
            }
        }

        [HttpGet("Pesquisa")]
        public IActionResult GetEstadoPesquisa([FromQuery] string valor)
        {
            try
            {
                //Query Criteria
                var lista = from o in _context.Estado.ToList()
                            where o.Sigla.ToUpper().Contains(valor.ToUpper())
                            || o.Nome.ToUpper().Contains(valor.ToUpper())
                            select o;

                //Entity

                /* lista = _context.Estado
                    .Where(o => o.Sigla.ToUpper().Contains(valor.ToUpper())
                    || o.Nome.ToUpper().Contains(valor.ToUpper()))
                    .ToList() ;*/

                //Expression

                /* Expression<Func<Estado, bool>> expressao = o => true;

                expressao = o => o.Sigla.ToUpper().Contains(valor.ToUpper())
                    || o.Nome.ToUpper().Contains(valor.ToUpper());

                lista = _context.Estado.Where(expressao).ToList(); */


                return Ok(lista);

                /*
                 SELECT * from estado WHERE upper(sigla) like upper('%valor%') or upper (nome) like upper('%valor%')
                 */
            }
            catch (Exception e)
            {
                return BadRequest($"Erro, pesquisa de estado. Exceção: {e.Message}");
            }
        }

        [HttpGet("Paginacao")]
        public IActionResult GetEstadoPaginacao([FromQuery] string valor, int skip, int take, bool ordemDesc)
        {
            try
            {
                //Query Criteria
                var lista = from o in _context.Estado.ToList()
                            where o.Sigla.ToUpper().Contains(valor.ToUpper())
                            || o.Nome.ToUpper().Contains(valor.ToUpper())
                            select o;   

                if (ordemDesc)
                {
                    lista = from o in lista
                            orderby o.Nome descending
                            select o;
                }
                else
                {
                    lista = from o in lista
                            orderby o.Nome ascending
                            select o;
                }

                var qtde = lista.Count();

                lista = lista
                        .Skip(skip)
                        .Take(take)
                        .ToList();

                var paginacaoResponse = new PaginacaoResponse<Estado>(lista, qtde, skip, take);

                return Ok(paginacaoResponse);

            }
            catch (Exception e)
            {
                return BadRequest($"Erro, pesquisa de estado. Exceção: {e.Message}");
            }
        }
    }
}

