using ApiAlunos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAlunos.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        public readonly AlunoContext _context;

        public TurmaRepository(AlunoContext context)
        {
            _context = context;
        }

        public async Task<Turma> Create(Turma turma)
        {
            _context.Turmas.Add(turma);
            await _context.SaveChangesAsync();
           
            return turma;
        }

        public async Task Delete (int Id)
        {
            var turmaToDelete = await _context.Turmas.FindAsync(Id);
            _context.Turmas.Remove(turmaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Turma>> Get()
        {
            return await _context.Turmas.ToListAsync();
        }
        public async Task<Turma> Get(int Id)
        {
            return await _context.Turmas.FindAsync(Id);
        }

        public async Task Update(Turma turma)
        {
            _context.Entry(turma).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }



    }
}
