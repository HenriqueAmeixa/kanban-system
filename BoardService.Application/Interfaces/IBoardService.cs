using BoardService.Application.DTOs.Board;

namespace BoardService.Application.Interfaces
{
    public interface IBoardService
    {
        Task<BoardSelectDTO> GetByIdAsync(int id);
        Task CreateAsync(BoardCreateDTO boardCreateDTO);
        Task UpdateAsync(BoardUpdateDTO boardUpdateDTO);
        Task DeleteAsync(int id);
    }
}
