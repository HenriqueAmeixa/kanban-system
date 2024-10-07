
namespace BoardService.Domain.Entities
{
    public class Board
    {
        public int Id { get; set; } 

        public string Name { get; set; }  

        public int OrganizationId { get; set; } 

        public ICollection<Column> Columns { get; set; } = new List<Column>();  

        public ICollection<UserBoard> UserBoards { get; set; } = new List<UserBoard>();  
        public ICollection<KanbanTask> KanbanTasks { get; set; } = new List<KanbanTask>();

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; }
    }
}
