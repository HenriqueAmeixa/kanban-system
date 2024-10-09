using BoardService.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Tests.Domain
{
    public class UserBoardTests
    {
        [Fact]
        public void CreateUserBoard_WithValidData_ShouldCreateUserBoard()
        {
            // Arrange
            var userId = 1;
            var boardId = 1;
            var isAdmin = true;
            var user = new User();
            // Act
            var userBoard = new UserBoard(userId, boardId, isAdmin);

            // Assert
            userBoard.UserId.Should().Be(userId);
            userBoard.BoardId.Should().Be(boardId);
            userBoard.IsAdmin.Should().Be(isAdmin);
        }
    }
}
