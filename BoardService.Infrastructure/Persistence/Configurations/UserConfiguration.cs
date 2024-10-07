using BoardService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardService.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(100);  

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(150);  

            builder.HasIndex(u => u.Email)
                   .IsUnique(); 


            builder.HasMany(u => u.UserBoards)
                   .WithOne(ub => ub.User)
                   .HasForeignKey(ub => ub.UserId)
                   .OnDelete(DeleteBehavior.Restrict);  
        }
    }
}
