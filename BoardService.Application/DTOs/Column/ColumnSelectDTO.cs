
namespace BoardService.Application.DTOs.Column
{
    public class ColumnSelectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int BoardId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
