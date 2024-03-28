using Backend.Model.Request;
using Backend.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    
    [ApiController]
    [Route ("controller")]
    public class ProdutoController : Controller
        
    {
        [HttpGet]
        [Route("obter")]
        public IActionResult ObterValorFrete([FromQuery] ProdutoRequest request)
        {
            var resultado = new ProdutoResponse();
            
            var custoFrete = (request.Distancia * request.Distancia) + (request.Peso * request.ValorAdicional) + (request.Largura * request.Altura * (request.ValorAdicional * 3));
            resultado.CustoFrete = Convert.ToInt32(custoFrete);
            return Ok(resultado);
            
        }
    }
}
