
namespace BoardService.Domain.Entities
{
    public class Column
    {
        public int Id { get; set; } 

        public string Name { get; set; }  

        public int Order { get; set; } 

        public int BoardId { get; set; } 
        public Board Board { get; set; } 

        public ICollection<KanbanTask> KanbanTasks { get; set; } = new List<KanbanTask>();
    }
}
