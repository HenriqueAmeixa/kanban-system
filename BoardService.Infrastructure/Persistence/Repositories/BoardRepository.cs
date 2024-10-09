using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Infrastructure.Persistence.Repositories
{

    public class BoardRepository : IBoardRepository
    {
        ApplicationDbContext _boardContext;
        public BoardRepository(ApplicationDbContext context)
        {
            _boardContext = context;
        }
        public async Task CreateAsync(Board board)
        {
            _boardContext.Boards.Add(board);
            await _boardContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _boardContext.Boards.Remove(await GetByIdAsync(id));
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            var boards = await _boardContext.Boards.FindAsync(id);
            if(boards != null)
                return boards;
            return null;
        }

        public async Task UpdateAsync(Board board)
        {
            _boardContext.Boards.Update(board);
            await _boardContext.SaveChangesAsync();
        }
    }
}
