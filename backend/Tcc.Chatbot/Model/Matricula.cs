using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tcc.Chatbot.Model
{
    public class Matricula
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
    }

    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder
                .ToTable("matricula")
                .HasKey(m => m.Id);
            builder
                .Property(m => m.Id)
                .HasColumnName("id");
            builder
                .HasOne(m => m.Aluno)
                .WithOne(a => a.Matricula)
                .HasForeignKey<Matricula>("aluno_id");
            builder
                .HasOne(m => m.Turma)
                .WithOne(a => a.Matricula)
                .HasForeignKey<Turma>("turma_id");
        }
    }
}