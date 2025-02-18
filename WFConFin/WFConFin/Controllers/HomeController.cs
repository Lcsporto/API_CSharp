using Microsoft.AspNetCore.Mvc;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult GetInformacao()
        {
            var result = "Retorno em texto";
            return Ok(result);
        }

        [HttpGet("info2")]
        public IActionResult GetInformacao2()
        {
            var result = "Retorno em texto 2";
            return Ok(result);
        }

        [HttpGet("info3/{valor}")]
        public IActionResult GetInformacao3([FromRoute] string valor)
        {
            var result = "Retorno em texto 3 - Valor: " + valor;
            return Ok(result);
        }
    }
}
