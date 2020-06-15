using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tcc.Chatbot.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Turma Turma { get; set; }
    }

    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder
                .ToTable("curso")
                .HasKey(t => t.Id);
            builder
                .Property(t => t.Id)
                .HasColumnName("id");
            builder
                .Property(t => t.Nome)
                .HasColumnName("nome");
        }
    }
}