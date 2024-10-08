
namespace BoardService.Domain.Exceptions
{
    public class KanbanTaskException : Exception
    {
        public KanbanTaskException(string message) : base(message) { }
    }

    public class KanbanTaskTitleInvalidException : KanbanTaskException
    {
        public KanbanTaskTitleInvalidException(string title)
            : base($"The task title '{title}' is invalid. It must be between 3 and 200 characters.") { }
    }

    public class KanbanTaskDescriptionInvalidException : KanbanTaskException
    {
        public KanbanTaskDescriptionInvalidException(string description)
            : base($"The task description is invalid. It must not exceed 500 characters.") { }
    }

    public class KanbanTaskColumnNotFoundException : KanbanTaskException
    {
        public KanbanTaskColumnNotFoundException(int columnId)
            : base($"The column with ID '{columnId}' was not found.") { }
    }

}
