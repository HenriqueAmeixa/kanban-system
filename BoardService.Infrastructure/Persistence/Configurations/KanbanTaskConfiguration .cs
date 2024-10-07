using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardService.Domain.Entities;

namespace BoardService.Infrastructure.Persistence.Configurations
{
    public class KanbanTaskConfiguration : IEntityTypeConfiguration<KanbanTask>
    {
        public void Configure(EntityTypeBuilder<KanbanTask> builder)
        {
            builder.HasKey(t => t.Id); 

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(200);  

            builder.Property(t => t.Description)
                   .HasMaxLength(500);  

            builder.HasOne(t => t.Column)
                   .WithMany(c => c.KanbanTasks)
                   .HasForeignKey(t => t.ColumnId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Board)
                   .WithMany(t => t.KanbanTasks)
                   .HasForeignKey(t => t.BoardId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
