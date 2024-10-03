using BoardService.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace BoardService.Infrastructure.Persistence.Configurations
{
    public class UserBoardConfiguration : IEntityTypeConfiguration<UserBoard>
    {
        public void Configure(EntityTypeBuilder<UserBoard> builder)
        {
            builder.HasKey(ub => new { ub.UserId, ub.BoardId });  // Definindo a chave composta

            // Relacionamento com o User
            builder.HasOne(ub => ub.User)
                   .WithMany(u => u.UserBoards)
                   .HasForeignKey(ub => ub.UserId)
                   .OnDelete(DeleteBehavior.Cascade);  // Cascading delete nos relacionamentos

            // Relacionamento com o Board
            builder.HasOne(ub => ub.Board)
                   .WithMany(b => b.UserBoards)
                   .HasForeignKey(ub => ub.BoardId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
