using BoardService.Application.DTOs.Column;

namespace BoardService.Application.Interfaces
{
    public interface IColumnService
    {
        Task<ColumnSelectDTO> GetByIdAsync(int id);
        Task CreateAsync(ColumnCreateDTO columnCreateDTO);
        Task UpdateAsync(ColumnUpdateDTO columnUpdateDTO);
        Task DeleteAsync(int id);
    }
}
