using ApiTarefas.Data;
using ApiTarefas.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepo;

        public TarefasController(ITarefaRepository tarefaRepo)
        {
            _tarefaRepo = tarefaRepo;
        }

        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> GetTarefasAsync()
        {
            var result = await _tarefaRepo.GetTarefasAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("tarefa")]
        public async Task<IActionResult> GetTarefaById(int id)
        {
            var result = await _tarefaRepo.GetTarefaByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("tarefascontador")]
        public async Task<IActionResult> GetTarefasContador()
        {
            var result = await _tarefaRepo.GetTarefasEContadorAsync();
            return Ok(result);
        }



        [HttpPost]
        [Route("criartarefa")]
        public async Task<IActionResult> SaveAsync([FromBody] Tarefa novaTarefa)
        {
            var result = await _tarefaRepo.SaveAsync(novaTarefa);
            return Ok(result);
        }

        [HttpPost]
        [Route("atualizastatus")]
        public async Task<IActionResult> UpdateStatusAsync([FromBody] Tarefa atualizaTerefa)
        {
            var result = await _tarefaRepo.UpdateTarefaStatusAsyncAsync(atualizaTerefa);
            return Ok(result);
        }

        [HttpDelete]
        [Route("deletatarefa")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _tarefaRepo.DeleteAsync(id);
            return Ok(result);
        }
    }
}