
namespace BoardService.Domain.Entities
{
    public sealed class Board
    {
        public int Id { get; private set; } 

        public string Name { get; private set; }  

        public int OrganizationId { get; private set; } 

        public ICollection<Column> Columns { get; private set; } = new List<Column>();  

        public ICollection<UserBoard> UserBoards { get; private set; } = new List<UserBoard>();  
        public ICollection<KanbanTask> KanbanTasks { get; private set; } = new List<KanbanTask>();

        public DateTime CreatedAt { get; private set; } 

        public DateTime UpdatedAt { get; private set; }
    }
}
