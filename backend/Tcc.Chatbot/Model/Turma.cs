using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tcc.Chatbot.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public Curso Curso { get; set; }
        public Matricula Matricula { get; set; }
    }

    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder
                .ToTable("turma")
                .HasKey(t => t.Id);
            builder
                .Property(t => t.Id)
                .HasColumnName("id");
            builder
                .Property(t => t.Sala)
                .HasColumnName("sala");
            builder
                .HasOne(m => m.Curso)
                .WithOne(a => a.Turma)
                .HasForeignKey<Turma>("curso_id");
        }
    }
}