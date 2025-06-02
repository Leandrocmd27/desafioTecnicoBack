using desafioTecnicoBack.Context;
using desafioTecnicoBack.Models;
using desafioTecnicoBack.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace desafioTecnicoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacientesController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> Get()
        {
            var pacientes = _repository.GetPacientes();
            return Ok(pacientes);
        }

        [HttpGet("{id:int}", Name = "ObterPaciente")]
        public ActionResult<Paciente> Get(int id)
        {
            var paciente = _repository.GetPaciente(id);
            return Ok(paciente);
        }

        [HttpPost]
        public ActionResult Post(Paciente paciente)
        {
            var pacienteCriado = _repository.Create(paciente);

            return new CreatedAtRouteResult("ObterPaciente", new { id = pacienteCriado.PacienteId }, pacienteCriado);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Paciente paciente)
        {
            _repository.Update(paciente);
            return Ok(paciente);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var pacitenteExcluido = _repository.Delete(id);

            return Ok(pacitenteExcluido);
        }
    }
}
