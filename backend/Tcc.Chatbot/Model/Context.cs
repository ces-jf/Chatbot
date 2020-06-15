using Microsoft.EntityFrameworkCore;

namespace Tcc.Chatbot.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new AlunoConfiguration())
                .ApplyConfiguration(new CursoConfiguration())
                .ApplyConfiguration(new TurmaConfiguration())
                .ApplyConfiguration(new MatriculaConfiguration());
        }
    }
}