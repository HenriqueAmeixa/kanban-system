
namespace BoardService.Domain.Entities
{
    public class KanbanTask
    {
        public int Id { get; set; }
        public int ColumnId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }
        public Column Column { get; set; }
    }
}
