using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tcc.Chatbot.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Inscricao { get; set; }
        public Matricula Matricula { get; set; }
    }

    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder
                .ToTable("aluno")
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id)
                .HasColumnName("id");
            builder
                .Property(a => a.Nome)
                .HasColumnName("nome");
            builder
                .Property(a => a.Inscricao)
                .HasColumnName("inscricao");
        }
    }
}