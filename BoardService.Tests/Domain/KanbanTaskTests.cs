using BoardService.Domain.Entities;
using BoardService.Domain.Exceptions;
using FluentAssertions;

namespace BoardService.Tests.Domain
{
    public class KanbanTaskTests
    {
        [Fact]
        public void CreateTask_WithValidData_ShouldCreateTask()
        {
            // Arrange
            var title = "Task 1";
            var description = "Complete the task";
            var columnId = 1;

            // Act
            var task = new KanbanTask(title, description, columnId);

            // Assert
            task.Title.Should().Be(title);
            task.Description.Should().Be(description);
            task.ColumnId.Should().Be(columnId);
        }

        [Fact]
        public void CreateTask_WithShortTitle_ShouldThrowException()
        {
            // Arrange
            var title = "T";
            var description = "Complete the task";
            var columnId = 1;

            // Act
            Action act = () => new KanbanTask(title, description, columnId);

            // Assert
            act.Should().Throw<KanbanTaskException>()
               .WithMessage($"The task title '{title}' is invalid. It must be between 3 and 200 characters.");
        }

        [Fact]
        public void CreateTask_WithLongTitle_ShouldThrowException()
        {
            // Arrange
            var title = new string('A', 201);
            var description = "Complete the task";
            var columnId = 1;

            // Act
            Action act = () => new KanbanTask(title, description, columnId);

            // Assert
            act.Should().Throw<KanbanTaskException>()
               .WithMessage($"The task title '{title}' is invalid. It must be between 3 and 200 characters.");
        }

        [Fact]
        public void CreateTask_WithValidColumn_ShouldLinkColumnCorrectly()
        {
            // Arrange
            var title = "Task 1";
            var description = "Complete the task";
            var columnId = 1;

            // Act
            var task = new KanbanTask(title, description, columnId);

            // Assert
            task.ColumnId.Should().Be(columnId);
        }
        [Fact]
        public void KanbanTask_Should_Throw_KanbanTaskColumnNotFoundException_When_ColumnId_Is_Invalid()
        {
            // Arrange
            string taskTitle = "Test Task";
            string taskDescription = "This is a test task";
            int invalidColumnId = 0;

            // Act
            Action act = () => new KanbanTask(taskTitle, taskDescription, invalidColumnId);

            // Assert
            act.Should().Throw<KanbanTaskColumnNotFoundException>()
               .WithMessage($"The column with ID '{invalidColumnId}' was not found.");
        }
    }
}

