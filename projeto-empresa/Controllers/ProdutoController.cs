using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_empresa.Dto;

namespace projeto_empresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("/get-id")]
        public async Task<IActionResult> Get(int id) 
        {
            try
            {
                return Ok("Tudo certo");
            }
            catch (Exception)
            {

                return BadRequest("Tudo errado");
            }
        }

        [HttpGet("/get-all")]
        public async Task<IActionResult> GetAll() 
        {
            try
            {
                return Ok("Tudo ok");
            }
            catch (Exception)
            {

                return BadRequest("Tudo errado");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CriarProdutoDTO produto) 
        {
            try
            {
                return Ok("Tudo certo");
            }
            catch (Exception)
            {

                return BadRequest("Tudo errado");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(AtualizarProdutoDTO atualizarProduto) 
        {
            try
            {
                return Ok("Tudo ok");
            }
            catch (Exception)
            {

                return BadRequest("Tudo errado");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            try
            {
                return Ok ("Tudo ok");
            }
            catch (Exception)
            {

                return BadRequest("Tudo errado");
            }
        }
    }
}
