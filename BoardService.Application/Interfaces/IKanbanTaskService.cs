using BoardService.Application.DTOs.KanbanTask;

namespace BoardService.Application.Interfaces
{
    public interface IKanbanTaskService
    {
        Task<KanbanTaskSelectDTO> GetByIdAsync(int id);
        Task CreateAsync(KanbanTaskCreateDTO kanbanTaskCreateDTO);
        Task UpdateAsync(KanbanTaskUpdateDTO kanbanTaskUpdateDTO);
        Task DeleteAsync(int id);
    }
}
