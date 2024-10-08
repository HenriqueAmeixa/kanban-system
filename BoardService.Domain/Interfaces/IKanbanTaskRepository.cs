using BoardService.Domain.Entities;

namespace BoardService.Domain.Interfaces
{
    public interface IKanbanTaskRepository
    {
        Task<KanbanTask> GetByIdAsync(int id);
        Task CreateAsync(KanbanTask kanbanTask);
        Task UpdateAsync(KanbanTask kanbanTask);
        Task DeleteAsync(int id);
    }
}
