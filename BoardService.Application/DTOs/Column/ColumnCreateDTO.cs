
namespace BoardService.Application.DTOs.Column
{
    public class ColumnCreateDTO
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public int BoardId { get; set; }
    }
}
