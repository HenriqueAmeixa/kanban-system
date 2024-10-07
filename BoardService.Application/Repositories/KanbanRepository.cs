using BoardService.Infrastructure.Persistence;


namespace BoardService.Application.Repositories
{
    public class KanbanRepository
    {
        private readonly BoardDbContext _context;

        public KanbanRepository(BoardDbContext context)
        {
            _context = context;
        }
    }
}
