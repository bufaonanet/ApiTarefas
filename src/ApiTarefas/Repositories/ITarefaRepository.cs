using ApiTarefas.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTarefas.Repositories
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasAsync();

        Task<Tarefa> GetTarefaByIdAsync(int id);

        Task<TarefaContainer> GetTarefasEContadorAsync();

        Task<int> SaveAsync(Tarefa novaTarefa);

        Task<int> UpdateTarefaStatusAsyncAsync(Tarefa atualizaTarefa);

        Task<int> DeleteAsync(int id);
    }
}