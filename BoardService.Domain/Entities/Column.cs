
using BoardService.Domain.Exceptions;

namespace BoardService.Domain.Entities
{
    public class Column
    {
        public int Id { get; private set; } 

        public string Name { get; private set; }  

        public int Order { get; private set; } 

        public int BoardId { get; private set; } 
        public Board Board { get; private set; } 

        public ICollection<KanbanTask> KanbanTasks { get; private set; } = new List<KanbanTask>();

        public Column(string name, int order, int boardId)
        {
            SetName(name);
            SetOrder(order);
            SetBoard(boardId);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 100)
            {
                throw new InvalidColumnNameException(name);
            }

            Name = name;
        }

        public void SetOrder(int order)
        {
            if (order <= 0)
            {
                throw new InvalidColumnOrderException(order);
            }

            Order = order;
        }

        public void SetBoard(int boardId)
        {
            if (boardId == null)
            {
                throw new BoardNotFoundException(boardId);
            }

            BoardId = boardId;
        }
    }
}
