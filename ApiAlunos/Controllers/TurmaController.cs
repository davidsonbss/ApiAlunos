using ApiAlunos.Models;
using ApiAlunos.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAlunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaController(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<Turma>> GetTurmas()
        {
            return await _turmaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetTurmas(int id)
        {
            return await _turmaRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Turma>> PostTurmas([FromBody] Turma turma)
        {
            var newTurma = await _turmaRepository.Create(turma);
            return CreatedAtAction(nameof(GetTurmas), new { id = newTurma.Id }, newTurma);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var turmaToDelete = await _turmaRepository.Get(id);

            if (turmaToDelete == null)
                return NotFound();

            await _turmaRepository.Delete(turmaToDelete.Id);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> PutAlunos(int id, [FromBody] Turma turma)
        {
            if (id != turma.Id)
                return BadRequest();

            await _turmaRepository.Update(turma);

            return NoContent();
        }

    }
}
