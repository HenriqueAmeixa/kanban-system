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
    public class ColumnConfiguration : IEntityTypeConfiguration<Column>
    {
        public void Configure(EntityTypeBuilder<Column> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);  

            builder.Property(c => c.Order)
                   .IsRequired();

   
            builder.HasOne(c => c.Board)
                   .WithMany(b => b.Columns)
                   .HasForeignKey(c => c.BoardId)
                   .OnDelete(DeleteBehavior.Cascade);  
        }
    }
}
