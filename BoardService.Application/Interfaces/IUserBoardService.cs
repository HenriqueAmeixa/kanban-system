using BoardService.Application.DTOs.UserBoard;

namespace BoardService.Application.Interfaces
{
    public interface IUserBoardService
    {
        Task<UserBoardSelectDTO> GetByIdAsync(int id);
        Task CreateAsync(UserBoardCreateDTO userBoardCreateDTO);
        Task UpdateAsync(UserBoardUpdateDTO userBoardUpdateDTO);
        Task DeleteAsync(int id);
    }
}
