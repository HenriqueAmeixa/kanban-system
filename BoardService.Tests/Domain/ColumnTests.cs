using BoardService.Domain.Entities;
using BoardService.Domain.Exceptions;
using FluentAssertions;

namespace BoardService.Tests.Domain
{
    public class ColumnTests
    {
        [Fact]
        public void CreateColumn_WithValidData_ShouldCreateColumn()
        {
            // Arrange
            var name = "To Do";
            var order = 1;
            var boardId = 1;

            var boardName = "Project Board";
            var boardDescription = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            var board = new Board(boardName, boardDescription, organizationId);
            var column = new Column(name, order, boardId, board);


            // Assert
            column.Name.Should().Be(name);
            column.Order.Should().Be(order);
            column.BoardId.Should().Be(boardId);
            column.Board.Should().Be(board);
        }

        [Fact]
        public void CreateColumn_WithShortName_ShouldThrowException()
        {
            // Arrange
            var name = "T";
            var order = 1;
            var boardId = 1;
            var boardName = "Project Board";
            var boardDescription = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            var board = new Board(boardName, boardDescription, organizationId);
            Action act = () => new Column(name, order, boardId, board);

            // Assert
            act.Should().Throw<ColumnException>()
               .WithMessage($"The column name '{name}' is invalid. It must be between 3 and 100 characters.");
        }

        [Fact]
        public void CreateColumn_WithLongName_ShouldThrowException()
        {
            // Arrange
            var name = new string('A', 101);
            var order = 1;
            var boardId = 1;

            var boardName = "Project Board";
            var boardDescription = "Board for managing project tasks";
            var organizationId = 1;

            // Act
            var board = new Board(boardName, boardDescription, organizationId);
            Action act = () => new Column(name, order, boardId, board);

            // Assert
            act.Should().Throw<ColumnException>()
               .WithMessage($"The column name '{name}' is invalid. It must be between 3 and 100 characters.");
        }
    }
}
