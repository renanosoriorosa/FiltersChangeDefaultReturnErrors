using FiltersChangeDefaultReturnErrors.Filters;
using FiltersChangeDefaultReturnErrors.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiltersChangeDefaultReturnErrors.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateProduto(Produto produto)
        {
            return Ok(new
            {
                success = true,
                message = produto
            });
        }
    }
}
