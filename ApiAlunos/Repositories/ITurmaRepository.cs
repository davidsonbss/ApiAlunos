using ApiAlunos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAlunos.Repositories
{
    public interface ITurmaRepository
    {
        Task<IEnumerable<Turma>> Get();
        Task<Turma> Get(int Id);
        Task<Turma> Create(Turma turma);
        Task Update(Turma turma);
        Task Delete(int Id);

    }
}
