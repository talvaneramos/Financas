using Financas.Domain.Dtos;
using Financas.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaDomainService _categoriaDomainService;

        public CategoriaController(ICategoriaDomainService categoriaDomainService)
        {
            _categoriaDomainService = categoriaDomainService;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(CriarCategoriaDto dto)
        {
            var id = await _categoriaDomainService.Criar(dto);
            return StatusCode(201, new
            {
                mensagem = "Categoria cadastrada com sucesso. ",
            });
        }        
        
    }
}
