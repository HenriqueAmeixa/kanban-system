
namespace BoardService.Domain.Exceptions
{
    public class ColumnException : Exception
    {
        public ColumnException(string message) : base(message) { }
    }

    public class ColumnNotFoundException : ColumnException
    {
        public ColumnNotFoundException()
            : base("The column was not found.") { }
    }

    public class InvalidColumnNameException : ColumnException
    {
        public InvalidColumnNameException(string columnName)
            : base($"The column name '{columnName}' is invalid. It must be between 3 and 100 characters.") { }
    }

    public class InvalidColumnOrderException : ColumnException
    {
        public InvalidColumnOrderException(int order)
            : base($"The column order '{order}' is invalid. It must be a positive number.") { }
    }

    public class BoardNotFoundException : ColumnException
    {
        public BoardNotFoundException(int boardId)
            : base($"The board with ID '{boardId}' was not found.") { }
    }

}
