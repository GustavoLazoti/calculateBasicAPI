using Microsoft.AspNetCore.Mvc;
using CalculatorAPI.Services;
using cSharpLogicPrograming.Models;
using cSharpLogicPrograming.View;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("CalculatorAPI")]
    public class calculadoraFirstController : Controller
    {
        
        [HttpGet()]
        public ActionResult Test() {
            return Ok("Teste OK");
        }
        [HttpPost("calculate")]
        public ActionResult<MathOperation> realizar_soma([FromBody] RequestOperations requestOperations)
        {
            var calculadora = new CalculadoraService();
            return Ok(calculadora.ExecOperation(requestOperations));
        }

    }
}