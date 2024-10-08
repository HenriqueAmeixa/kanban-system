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

            // Act

            var column = new Column(name, order, boardId);


            // Assert
            column.Name.Should().Be(name);
            column.Order.Should().Be(order);
            column.BoardId.Should().Be(boardId);
        }

        [Fact]
        public void CreateColumn_WithShortName_ShouldThrowException()
        {
            // Arrange
            var name = "T";
            var order = 1;
            var boardId = 1;

            // Act
            Action act = () => new Column(name, order, boardId);

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
            // Act
            Action act = () => new Column(name, order, boardId);

            // Assert
            act.Should().Throw<ColumnException>()
               .WithMessage($"The column name '{name}' is invalid. It must be between 3 and 100 characters.");
        }
    }
}
