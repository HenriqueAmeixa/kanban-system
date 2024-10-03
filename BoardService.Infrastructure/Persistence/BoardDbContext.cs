using BoardService.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace BoardService.Infrastructure.Persistence
{
    public class BoardDbContext : DbContext
    {
        public BoardDbContext(DbContextOptions<BoardDbContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<KanbanTask> Tasks { get; set; }
        public DbSet<UserBoard> UserBoards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoardDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
