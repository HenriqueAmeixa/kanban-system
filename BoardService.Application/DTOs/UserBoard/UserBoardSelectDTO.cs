
namespace BoardService.Application.DTOs.UserBoard
{
    public class UserBoardSelectDTO
    {
        public int UserId { get; set; }
        public int BoardId { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
