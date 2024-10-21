using BoardService.Domain.Entities;

namespace BoardService.Domain.Interfaces
{
    public interface IBoardRepository
    {
        Task<Board> GetByIdAsync(int id);
        Task<Board> CreateAsync(Board board);
        Task UpdateAsync(Board board);
        Task DeleteAsync(int id);
    }
}
