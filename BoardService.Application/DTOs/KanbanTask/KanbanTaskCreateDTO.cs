namespace BoardService.Application.DTOs.KanbanTask
{
    public class KanbanTaskCreateDTO
    {
        public int ColumnId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
