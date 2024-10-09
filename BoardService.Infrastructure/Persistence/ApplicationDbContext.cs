using BoardService.Domain.Entities;
using BoardService.Infrastructure.Configurations;
using BoardService.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;



namespace BoardService.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<KanbanTask> KanbanTasks { get; set; }
        public DbSet<UserBoard> UserBoards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BoardConfiguration());
            modelBuilder.ApplyConfiguration(new UserBoardConfiguration());
            modelBuilder.ApplyConfiguration(new KanbanTaskConfiguration());
            modelBuilder.ApplyConfiguration(new ColumnConfiguration());
        }
    }
}
