
using BoardService.Domain.Exceptions;

namespace BoardService.Domain.Entities
{
    public class KanbanTask
    {
        public int Id { get; private set; }
        public int ColumnId {  get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Column Column { get; private set; }


        public KanbanTask(string title, string description, int columnId, Column column)
        {
            SetTitle(title);
            SetDescription(description);
            SetColumn(columnId, column);
        }

        // Validação e definição do título
        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title) || title.Length < 3 || title.Length > 200)
            {
                throw new KanbanTaskTitleInvalidException(title);
            }

            Title = title;
        }

        // Validação e definição da descrição
        public void SetDescription(string description)
        {
            if (description != null && description.Length > 500)
            {
                throw new KanbanTaskDescriptionInvalidException(description);
            }

            Description = description;
        }

        // Validação e definição da coluna
        public void SetColumn(int columnId, Column column)
        {
            if (column == null)
            {
                throw new KanbanTaskColumnNotFoundException(columnId);
            }

            ColumnId = columnId;
            Column = column;
        }
    }
}
