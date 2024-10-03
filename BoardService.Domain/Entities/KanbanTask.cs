
namespace BoardService.Domain.Entities
{
    public class KanbanTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }
    }
}
