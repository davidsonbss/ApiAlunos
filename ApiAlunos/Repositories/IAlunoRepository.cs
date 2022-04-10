using ApiAlunos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAlunos.Repositories
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> Get();
        Task<Aluno> Get(int Id);
        Task<Aluno> Create(Aluno aluno);
        Task Update(Aluno aluno);
        Task Delete(int Id);



    }
}
