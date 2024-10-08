using BoardService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Domain.Interfaces
{
    public interface IUserBoardRepository
    {
        Task<UserBoard> GetByIdAsync(int id);
        Task CreateAsync(UserBoard userBoard);
        Task UpdateAsync(UserBoard userBoard);
        Task DeleteAsync(int id);
    }
}
