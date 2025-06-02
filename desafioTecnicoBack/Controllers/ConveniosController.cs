using desafioTecnicoBack.Context;
using desafioTecnicoBack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace desafioTecnicoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConveniosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConveniosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Convenio>> Get()
        {
            
            var convenios = _context.Convenios.ToList();
            if (convenios.Count == 0)
            {
                return NotFound("Nenhum Convenio Encontrado");
            }
            return convenios;
        }

        
    }
}
