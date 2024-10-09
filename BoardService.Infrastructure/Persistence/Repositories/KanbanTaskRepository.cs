using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Infrastructure.Persistence.Repositories
{
    public class KanbanTaskRepository : IKanbanTaskRepository
    {
        public Task CreateAsync(KanbanTask kanbanTask)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<KanbanTask> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(KanbanTask kanbanTask)
        {
            throw new NotImplementedException();
        }
    }
}
