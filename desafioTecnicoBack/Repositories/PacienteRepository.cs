using desafioTecnicoBack.Context;
using desafioTecnicoBack.Models;

namespace desafioTecnicoBack.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Paciente> GetPacientes()
        {
            return _context.Pacientes.ToList();
        }
        public Paciente GetPaciente(int id)
        {
            return _context.Pacientes.FirstOrDefault(c => c.PacienteId == id);
        }        
        public Paciente Create(Paciente paciente)
        {
            if (paciente is null)
                throw new ArgumentNullException(nameof(Paciente));

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();

            return paciente;
        }

        public Paciente Update(Paciente paciente)
        {
            if (paciente is null)
                throw new ArgumentNullException(nameof(Paciente));

            _context.Entry(paciente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return paciente;
        }
        public Paciente Delete(int id)
        {
            var paciente =  _context.Pacientes.Find(id);

            if (paciente is null)
                throw new ArgumentNullException(nameof(Paciente));

            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();

            return paciente;
        }
    }
}
