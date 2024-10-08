using BoardService.Domain.Entities;
using BoardService.Domain.Exceptions;
using FluentAssertions;

namespace BoardService.Tests.Domain
{
    public class BoardTests
    {
        [Fact]
        public void CreateBoard_WithValidData_ShouldCreateBoard()
        {
            // Arrange
            var name = "Project Board";
            var description = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            var board = new Board(name, description, organizationId);


            // Assert
            board.Name.Should().Be(name);
            board.Description.Should().Be(description);
            board.OrganizationId.Should().Be(organizationId);
        }

        [Fact]
        public void CreateBoard_WithShortName_ShouldThrowException()
        {
            // Arrange
            var name = "B";
            var description = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            Action act = () => new Board(name, description, organizationId);

            // Assert
            act.Should().Throw<BoardException>()
               .WithMessage("Board title must be at least 3 characters long.");
        }

        [Fact]
        public void CreateBoard_WithLongName_ShouldThrowException()
        {
            // Arrange
            var name = new string('A', 101);
            var description = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            Action act = () => new Board(name, description, organizationId);

            // Assert
            act.Should().Throw<BoardException>()
               .WithMessage("Board title must not exceed 100 characters.");
        }
    }
}
