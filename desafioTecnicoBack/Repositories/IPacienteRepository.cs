using desafioTecnicoBack.Models;

namespace desafioTecnicoBack.Repositories
{
    public interface IPacienteRepository
    {
        IEnumerable<Paciente> GetPacientes();
        Paciente GetPaciente(int id);
        Paciente Create(Paciente paciente);
        Paciente Update(Paciente paciente);
        Paciente Delete(int id);


    }
}
