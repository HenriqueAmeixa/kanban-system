
namespace BoardService.Application.DTOs.UserBoard
{
    public class UserBoardUpdateDTO
    {
        public int UserId { get; set; }
        public int BoardId { get; set; }
        public bool IsAdmin { get; set; }
    }
}
