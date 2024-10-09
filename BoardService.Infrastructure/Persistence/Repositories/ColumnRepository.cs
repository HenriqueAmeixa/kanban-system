using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Infrastructure.Persistence.Repositories
{
    public class ColumnRepository : IColumnRepository
    {
        ApplicationDbContext _columnContext;
        public ColumnRepository(ApplicationDbContext context)
        {
            _columnContext = context;
        }
        public async Task CreateAsync(Column column)
        {
            var Column = await _columnContext.Columns.AddAsync(column);
            await _columnContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _columnContext.Columns.Remove(await GetByIdAsync(id));
            await _columnContext.SaveChangesAsync();
        }

        public async Task<Column> GetByIdAsync(int id)
        {
            var Column = await _columnContext.Columns.FindAsync(id);
            return Column;
        }

        public async Task UpdateAsync(Column column)
        {
            _columnContext.Columns.Update(column);
            await _columnContext.SaveChangesAsync();
        }
    }
}
