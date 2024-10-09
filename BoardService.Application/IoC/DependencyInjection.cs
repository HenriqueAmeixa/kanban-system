using BoardService.Domain.Interfaces;
using BoardService.Infrastructure.Persistence;
using BoardService.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BoardService.Application.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IColumnRepository, ColumnRepository>();
            services.AddScoped<IKanbanTaskRepository, KanbanTaskRepository>();
            services.AddScoped<IUserBoardRepository, UserBoardRepository>();

            return services;
        }
    }
}
