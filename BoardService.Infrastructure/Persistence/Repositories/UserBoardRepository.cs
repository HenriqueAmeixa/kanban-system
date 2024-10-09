using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Infrastructure.Persistence.Repositories
{
    public class UserBoardRepository : IUserBoardRepository
    {
        public Task CreateAsync(UserBoard userBoard)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserBoard> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserBoard userBoard)
        {
            throw new NotImplementedException();
        }
    }
}
