//using Microsoft.AspNetCore.Mvc;
//using projeto_empresa.Models;
//using projeto_empresa.Services.Inteface;

//namespace projeto_empresa.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoriaController : ControllerBase
//    {
//        private readonly ICategoriaService _categoriaService;

//        public CategoriaController(ICategoriaService categoriaService)
//        {
//            _categoriaService = categoriaService;
//        }

//        [HttpGet("/get-by-id")]
//        public async Task<IActionResult> Get(int id)
//        {
//            try
//            {
//                var resultado = _categoriaService.Get(id);
//                return Ok(resultado);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("deu erro");
//            }
//        }

//        [HttpGet("/get-all")]
//        public async Task<IActionResult> GetAll()
//        {
//            try
//            {
//                var resultado = _categoriaService.GetAll();
//                return Ok(resultado);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("deu erro");
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post(CategoriaDTO dto)
//        {
//            try
//            {
//                _categoriaService.Post(dto);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("deu erro");
//            }
//        }

//        [HttpPut]
//        public async Task<IActionResult> Put(int id, CategoriaDTO dto)
//        {
//            try
//            {
//                _categoriaService.Update(id, dto);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("deu erro");
//            }
//        }

//        [HttpDelete]
//        public async Task<IActionResult> Delete(int id)
//        {
//            try
//            {
//                _categoriaService.Delete(id);
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("deu erro");
//            }
//        }
//    }
//}
