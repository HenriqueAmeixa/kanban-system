using BoardService.Domain.Entities;

namespace BoardService.Domain.Interfaces
{
    public interface IColumnRepository
    {
        Task<Column> GetByIdAsync(int id);
        Task CreateAsync(Column column);
        Task UpdateAsync(Column column);
        Task DeleteAsync(int id);
    }
}
