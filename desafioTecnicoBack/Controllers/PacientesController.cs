using desafioTecnicoBack.Context;
using desafioTecnicoBack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace desafioTecnicoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PacientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> Get()
        {
            
            var pacientes = _context.Pacientes.ToList();
            if (pacientes.Count == 0)
            {
                return NotFound("Nenhum Paciente Encontrado");
            }
            return pacientes;
        }

        [HttpGet("{id:int}", Name = "ObterPaciente")]
        public ActionResult<Paciente> Get(int id)
        {
            var paciente = _context.Pacientes.FirstOrDefault(p => p.PacienteId == id);
            if (paciente is null)
            {
                return NotFound("Nenhum Paciente Encontrado");
            }
            return paciente;
        }

        [HttpPost]
        public ActionResult Post(Paciente paciente)
        {
            if (paciente is null)
                return BadRequest();

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPaciente", new { id = paciente.PacienteId }, paciente);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Paciente paciente)
        {
            if (id != paciente.PacienteId)
            {
                return BadRequest();
            }
            _context.Entry(paciente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(paciente);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var paciente = _context.Pacientes.FirstOrDefault(p => p.PacienteId == id);
            if (paciente is null)
            {
                return NotFound("Paciente Não Encontrado");
            }
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();

            return Ok(paciente);
        }
    }
}
