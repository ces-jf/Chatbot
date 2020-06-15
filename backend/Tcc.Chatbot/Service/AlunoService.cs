using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tcc.Chatbot.Model;

namespace Tcc.Chatbot.Service
{
    public class AlunoService
    {
        private readonly Context _context;
        public AlunoService(Context context) =>
            (_context) = (context);

        public Task<Aluno> GetAsync(int id)
        {
            return _context.Alunos
                .Where(a => a.Inscricao == 1)
                .Include(a => a.Matricula.Turma)
                .FirstOrDefaultAsync();
        }
    }
}