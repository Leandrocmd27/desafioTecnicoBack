using desafioTecnicoBack.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioTecnicoBack.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        } 
        
        public DbSet<Paciente>? Pacientes { get; set; }
        public DbSet<Convenio>? Convenios { get; set; }
    }
}
